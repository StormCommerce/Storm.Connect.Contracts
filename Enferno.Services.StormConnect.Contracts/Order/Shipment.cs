using System;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Shipment", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Shipment : Entity
    {
        [DataMember(Order = 1)]
        public Guid ApplicationKey { get; set; }
        [DataMember(Order = 2)]
        public string ShipmentNo { get; set; }
        [DataMember(Order = 3)]
        public string DeliveryNoteNo { get; set; }
        [DataMember(Order = 4)]
        public string InvoiceNo { get; set; }
        [DataMember(Order = 5)]
        public string Comment { get; set; }
        [DataMember(Order = 6)]
        public Address ShipmentWarehouse { get; set; }
        [DataMember(Order = 7)]
        public string SourceWarehouseCode { get; set; }
        [DataMember(Order = 8)]
        public string TargetWarehouseCode { get; set; }
        [DataMember(Order = 9)]
        public Address TargetWarehouseAddress { get; set; }
        [DataMember(Order = 10)]
        public ShipmentItems Items { get; set; }
    }
}
