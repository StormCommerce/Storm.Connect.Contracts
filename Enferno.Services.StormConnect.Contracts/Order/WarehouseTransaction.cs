using System;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "WarehouseTransaction", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class WarehouseTransaction : Entity
    {
        [DataMember(Order = 1)]
        public string TransactionNo { get; set; }
        [DataMember(Order = 2)]
        public DateTime TransactionDate { get; set; }
        [DataMember(Order = 3)]
        public string WarehouseCode { get; set; }
        [DataMember(Order = 4)]
        public string LocationCode { get; set; }
        [DataMember(Order = 5)]
        public string Type { get; set; }
        [DataMember(Order = 6)]
        public string OrderNo { get; set; }
        [DataMember(Order = 7)]
        public string PurchaseOrderNo { get; set; }
        [DataMember(Order = 8)]
        public string DeliveryNoteNo { get; set; }
        [DataMember(Order = 9)]
        public string ExternalReference { get; set; }
        [DataMember(Order = 10)]
        public string ReasonCode { get; set; }
        [DataMember(Order = 11)]
        public string Comment { get; set; }
        [DataMember(Order = 12)]
        public WarehouseTransactionItems Items { get; set; }
    }
}
