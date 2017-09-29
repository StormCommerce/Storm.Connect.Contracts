using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "SendOrderStatusRequest", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class SendOrderStatusRequest : Entity
    {
        [DataMember(Order = 1)]
        public int ClientOrderRef { get; set; }
        [DataMember(Order = 2)]
        public string ErpOrderNo { get; set; }
        [DataMember(Order = 3)]
        public List<OrderInfo> Infos { get; set; }
        [DataMember(Order = 4)]
        public OrderStatus OrderStatus { get; set; }
        [DataMember(Order = 5)]
        public int? AccountId { get; set; }
        [DataMember(Order = 6)]
        public List<OrderItemStatus> ItemStatuses { get; set; }
    }
}
