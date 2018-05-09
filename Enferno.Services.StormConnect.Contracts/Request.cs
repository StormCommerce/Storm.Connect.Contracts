using System;
using System.Collections.Generic;
using System.IO;
#if !NETCORE
using System.ServiceModel;
#endif
using Enferno.Services.StormConnect.Contracts.Utils;

namespace Enferno.Services.StormConnect.Contracts
{
#if !NETCORE
    [MessageContract]
#endif
    public class Request : IDisposable
    {
#if !NETCORE
        [MessageHeader(MustUnderstand = true)]
#endif
        public string Hash { get; set; }
        
#if !NETCORE
        [MessageBodyMember(Order = 1)]
#endif
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

#if !NETCORE
    [MessageContract]
#endif
    public class Request<T>: Request where T: Header
    {
#if !NETCORE
        [MessageHeader(MustUnderstand = true)]
#endif
        public T Header { get; set; }
    }

#if !NETCORE
    [MessageContract]
#endif
    public class Request<T, T2> : Request<T> where T : Header
    {
    }
}
