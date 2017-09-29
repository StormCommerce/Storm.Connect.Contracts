using System;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Supplier.Models
{
    [DataContract(Name = "SupplierOnHand", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier.Models")]
    public class SupplierOnHand
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }
        [DataMember(Order = 2)]
        public string WarehouseCode { get; set; }
        [DataMember(Order = 3)]
        public string LocationCode { get; set; }
        [DataMember(Order = 4)]
        public decimal Value { get; set; }
        [DataMember(Order = 5)]
        public decimal? IncomingValue { get; set; }
        [DataMember(Order = 6)]
        public DateTime? NextDeliveryDate { get; set; }
        [DataMember(Order = 7)]
        public DateTime? StoppedDate { get; set; }
        [DataMember(Order = 8)]
        public bool? IsReturnable { get; set; }
        [DataMember(Order = 9)]
        public int? LeadTimeDayCount { get; set; }
        [DataMember(Order = 10)]
        public decimal? ExternalStockValue { get; set; }
        [DataMember(Order = 11)]
        public decimal PackageValue { get; set; }
        [DataMember(Order = 12)]
        public decimal MinimumOrderValue { get; set; }
        [DataMember(Order = 13)]
        public bool IsActive { get; set; }
    }
}
