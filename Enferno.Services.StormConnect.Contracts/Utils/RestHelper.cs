using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using Newtonsoft.Json;

namespace Enferno.Services.StormConnect.Contracts.Utils
{
    public class RestHelper
    {
        public string BaseAddress { get; set; }
        public int ApplicationId { get; set; }
        public Guid SecretKey { get; set; }

        public T PostStream<T>(string url, Stream dataStream, object header = null, string method = "POST")
        {
            return SendStreamedData<T>(BaseAddress + url, ApplicationId, SecretKey, dataStream, header);
        }

        public T Get<T>(string url)
        {
            var webRequest = WebRequest.CreateHttp(BaseAddress + url);
            webRequest.Headers[HttpRequestHeader.Authorization] = CreateBasicAuthenticationHeaderValue(ApplicationId, SecretKey).ToString();
            using (var stream = webRequest.GetResponseWithTimeout().GetResponseStream())
                if (stream != null)
                    using (var sw = new StreamReader(stream))
                    {
                        var job = JsonConvert.DeserializeObject<T>(sw.ReadToEnd());

                        return job;
                    }

            throw new ApplicationException("Stream could not be instanced.");
        }

        public static AuthenticationHeaderValue CreateBasicAuthenticationHeaderValue(int applicationId, Guid secretKey)
        {
            var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{applicationId}:{secretKey.ToString("D")}"));

            return new AuthenticationHeaderValue("Basic", credentials); 
        }

        public static T SendStreamedData<T, T2, T3>(
            string url,
            int applicationId,
            Guid secretKey,
            MyRequest<T2, T3> request,
            string method = "POST",
            int? timeout = null)
        {
            using (var dataStream = request.GetStream())
            {
                return SendStreamedData<T>(url, applicationId, secretKey, dataStream, request.Header, method, timeout);
            }
        }

        public static T SendStreamedData<T>(
            string url,
            int applicationId,
            Guid secretKey,
            Stream dataStream,
            object header = null,
            string method = "POST",
            int? timeout = null)
        {
            var webRequest = WebRequest.CreateHttp(url);
            try
            {
                webRequest.Headers[HttpRequestHeader.Authorization] = CreateBasicAuthenticationHeaderValue(applicationId, secretKey).ToString();
                webRequest.Method = method;
                webRequest.AllowWriteStreamBuffering = false;
                webRequest.SendChunked = true;
                if (timeout.HasValue)
                {
                    webRequest.Timeout = timeout.Value;
                }
                if (header != null)
                {
                    var jsonSerializerSettings = new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    };
                    webRequest.Headers["X-StormConnect-Header"] = JsonConvert.SerializeObject(header, Formatting.None, jsonSerializerSettings);
                }
                using (var inputStream = webRequest.GetRequestStreamWithTimeout())
                {
                    dataStream.CopyTo(inputStream);
                }
                using (var response = webRequest.GetResponseWithTimeout())
                {
                    using (var responseStream = response.GetResponseStream())
                        if (responseStream != null)
                            using (var sw = new StreamReader(responseStream))
                            {
                                var retval = sw.ReadToEnd();
                                var job = JsonConvert.DeserializeObject<T>(retval);

                                return job;
                            }

                    throw new ApplicationException("Stream could not be instanced.");
                }
            }
            catch (Exception)
            {
                webRequest.Abort();
                throw;
            }
        }

        public static string SerializeToQueryString(object obj)
        {
            var properties = obj.GetType().GetProperties();
            var kvps = new List<string>();
            foreach (var property in properties)
            {
                var tmp = property.GetValue(obj);
                if (tmp == null)
                {
                    continue;
                }
                
                string value;
                if (property.PropertyType.IsValueType)
                {
                    value = (string)Convert.ChangeType(property.GetValue(obj), typeof(string));
                }
                else if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(List<>))
                {
                    var list = (IList) tmp;
                    if (list.Count == 0)
                    {
                        continue;
                    }

                    var memberType = property.PropertyType.GenericTypeArguments[0];
                    var values = new List<string>();
                    foreach (var item in list)
                    {
                        if (memberType.IsEnum && memberType.GetEnumUnderlyingType() == typeof(int))
                        {
                            value = ((int) item).ToString(CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            value = (string)Convert.ChangeType(item, typeof(string));
                        }
                        values.Add(value);
                    }

                    value = string.Join(",", values);
                }
                else
                {
                    continue;
                }

                if (string.IsNullOrEmpty(value))
                {
                    continue;
                }

                kvps.Add($"{property.Name}={HttpUtility.UrlEncode(value)}");
            }

            return string.Join("&", kvps);
        }
    }
}
