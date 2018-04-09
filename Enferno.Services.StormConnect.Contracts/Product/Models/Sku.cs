using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "Sku", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class Sku
    {
        [DataMember]
        public string PartNo { get; set; }
        [DataMember]
        public SkuStatus Status { get; set; }
        [DataMember]
        public SkuType Type { get; set; }
        [DataMember]
        public string IntegrationPartNo { get; set; }
        [DataMember]
        public string CommodityCode { get; set; }
        [DataMember]
        public string EanCode { get; set; }
        [DataMember]
        public string TrackingCode { get; set; }
        [DataMember]
        public UnitMeasurementType UnitOfMeasurementType { get; set; }
        [DataMember]
        public decimal UnitOfMeasurementCount { get; set; }
        [DataMember]
        public bool? IsDropShipOnly { get; set; }
        [DataMember]
        public bool IsBuyable { get; set; }
        [DataMember]
        public string DiscountClass { get; set; }
        [DataMember]
        public decimal? RecommendedSalesQty { get; set; }
        [DataMember]
        public bool? IsRecommendedSalesQtyFixed { get; set; }
        [DataMember]
        public decimal? ActualWeight { get; set; }
        [DataMember]
        public decimal? VolumeWeight { get; set; }
        [DataMember]
        public decimal? LogisticWidth { get; set; }
        [DataMember]
        public decimal? LogisticHeight { get; set; }
        [DataMember]
        public decimal? LogisticDepth { get; set; }
        [DataMember]
        public SkuPriceList StandardPrice { get; set; }
        [DataMember]
        public IEnumerable<VatRate> VatRates { get; set; }
        [DataMember]
        public IEnumerable<SkuCulture> Cultures { get; set; }
        [DataMember]
        public DateTime? StartDate { get; set; }
        [DataMember]
        public DateTime? StopDate { get; set; }
        [DataMember]
        public IEnumerable<SkuStructureItem> StructureItems { get; set; }
    }
}
