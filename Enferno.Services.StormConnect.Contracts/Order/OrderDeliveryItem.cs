using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "OrderDeliveryItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class OrderDeliveryItem : Entity
    {
        [DataMember(Order = 1)]
        public int OrderDeliveryItemId { get; set; }
        [DataMember(Order = 2)]
        public int OrderDeliveryId { get; set; }
        [DataMember(Order = 3)]
        public long OrderItemId { get; set; }
        [DataMember(Order = 4)]
        public int Quantity { get; set; }
    }
}
