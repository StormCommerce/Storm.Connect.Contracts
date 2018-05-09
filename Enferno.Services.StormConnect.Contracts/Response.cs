#if !NETCORE
using System.ServiceModel;
#endif

namespace Enferno.Services.StormConnect.Contracts
{
#if !NETCORE
    [MessageContract]
#endif
    public class Response
    {
#if !NETCORE
        [MessageHeader(MustUnderstand = true)]
#endif
        public Header Header { get; set; }
#if !NETCORE
        [MessageHeader(MustUnderstand = true)]
#endif
        public ResponseStatus Status { get; set; }
    }
}
