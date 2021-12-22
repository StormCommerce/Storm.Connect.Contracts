using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "OrderDeliveryRequest", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class OrderDeliveryRequest : Entity
    {
        [DataMember(Order = 1)]
        public int OrderDeliveryId { get; set; }
        [DataMember(Order = 2)]
        public long OrderId { get; set; }
        [DataMember(Order = 3)]
        public int WarehouseId { get; set; }
        [DataMember(Order = 4)]
        public string OrderDeliveryRef { get; set; }
        [DataMember(Order = 5)]
        public DateTime DateDelivery { get; set; }
        [DataMember(Order = 6)]
        public DateTime DateCancelled { get; set; }
        [DataMember(Order = 7)]
        public string PluginName { get; set; }
        [DataMember(Order = 8)]
        public List<OrderDeliveryItem> OrderDeliveryItems { get; set; }
        [DataMember(Order = 9)]
        public int ApplicationId { get; set; }
        [DataMember(Order = 10)]
        public string ErpOrderNo { get; set; }
    }
}
