using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "OrderItemStatus", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class OrderItemStatus
    {
        [DataMember(Order = 1)]
        public string LineNo { get; set; }
        [DataMember(Order = 2)]
        public OrderStatus? ItemStatus { get; set; }
    }
}
