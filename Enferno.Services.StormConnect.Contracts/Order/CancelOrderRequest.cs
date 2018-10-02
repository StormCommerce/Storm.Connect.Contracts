using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "CancelOrderRequest", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class CancelOrderRequest
    {
        [DataMember(Order = 1)]
        public int ClientOrderRef { get; set; }

        [DataMember(Order = 2)]
        public string ErpOrderNo { get; set; }

        [DataMember(Order = 3)]
        public bool CancelPayment { get; set; }
    }
}
