using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{

    [DataContract(Name = "OrderResponse", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class OrderResponse 
    {
        [DataMember(Order = 1)]
        public string StatusCode { get; set; }
        [DataMember(Order = 2)]
        public string Description { get; set; }
        [DataMember(Order = 3)]
        public bool HasErpOrderNo { get; set; }
        [DataMember(Order = 4)]
        public string ErpOrderNo { get; set; }
    }
}
