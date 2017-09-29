using System.ServiceModel;

namespace Enferno.Services.StormConnect.Contracts
{
    [MessageContract]
    public class Response
    {
        [MessageHeader(MustUnderstand = true)]
        public Header Header { get; set; }
        [MessageHeader(MustUnderstand = true)]
        public ResponseStatus Status { get; set; }
    }
}
