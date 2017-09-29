using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SkuOnhand", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class SkuOnhand
    {
        [DataMember]
        public string PartNo { get; set; }
        [DataMember]
        public string LocationCode { get; set; }
        [DataMember]
        public string WarehouseCode { get; set; }
        [DataMember]
        public decimal OnhandValue { get; set; }
        [DataMember]
        public decimal? IncomingValue { get; set; }
        [DataMember]
        public DateTime? NextDeliveryDate { get; set; }
        [DataMember]
        public int? LeadTimeDayCount { get; set; }
        [DataMember]
        public decimal? OnOrderValue { get; set; }
        [DataMember]
        public decimal? MinimumValue { get; set; }
        [DataMember]
        public decimal? MaximumValue { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public IEnumerable<Info> Infos { get; set; }
    }
}
