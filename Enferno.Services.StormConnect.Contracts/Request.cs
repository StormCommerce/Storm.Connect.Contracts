using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using Enferno.Services.StormConnect.Contracts.Utils;

namespace Enferno.Services.StormConnect.Contracts
{
    [MessageContract]
    public class Request : IDisposable
    {
        [MessageHeader(MustUnderstand = true)]
        public string Hash { get; set; }

        [MessageBodyMember(Order = 1)]
        public Stream Stream;

        public void Dispose()
        {
            if (Stream == null) return;
            Stream.Dispose();
            Stream = null;
        }

        public static Request<T, T2> CreateFromEnumeration<T, T2>(T header, IEnumerable<T2> enumeration) where T : Header
        {
            var retval = new Request<T, T2>
            {
                Header = header,
                Stream = new EnumeratorStream(enumeration)
            }
                ;
            return retval;
        }
    }

    [MessageContract]
    public class Request<T>: Request where T: Header
    {
        [MessageHeader(MustUnderstand = true)]
        public T Header { get; set; }
    }

    [MessageContract]
    public class Request<T, T2> : Request<T> where T : Header
    {
    }
}
