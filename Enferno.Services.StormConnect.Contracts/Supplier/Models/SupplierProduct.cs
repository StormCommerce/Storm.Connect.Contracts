using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Common;
using Enferno.Services.StormConnect.Contracts.ExternalContent.Models;
using Enferno.Services.StormConnect.Contracts.Product.Models;

namespace Enferno.Services.StormConnect.Contracts.Supplier.Models
{
    [DataContract(Name = "SupplierProduct", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier.Models")]
    public class SupplierProduct
    {
        [DataMember(Order = 1)]
        public string SupplierPartNo { get; set; }
        [DataMember(Order = 2)]
        public string ProductName { get; set; }
        [DataMember(Order = 3)]
        public string CategoryCode { get; set; }
        [DataMember(Order = 4)]
        public string ProductType { get; set; }
        [DataMember(Order = 5)]
        public string Manufacturer { get; set; }
        [DataMember(Order = 6)]
        public string ManufacturerPartNo { get; set; }
        [DataMember(Order = 7)]
        public string EanCode { get; set; }
        [DataMember(Order = 8)]
        public string CommodityCode { get; set; }
        [DataMember(Order = 9)]
        public decimal GrossWeight { get; set; }
        [DataMember(Order = 10)]
        public decimal NetWeight { get; set; }
        [DataMember(Order = 11)]
        public UnitOfMeasurementType UnitOfMeasurementCode { get; set; }
        [DataMember(Order = 12)]
        public int UnitOfMeasurementCount { get; set; }
        [DataMember(Order = 13)]
        public int VatCode { get; set; }
        [DataMember(Order = 14)]
        public Image MainImage { get; set; }
        [DataMember(Order = 15)]
        public List<SupplierOnHand> OnHand { get; set; }
        [DataMember(Order = 16)]
        public List<SupplierPrice> PriceList { get; set; }
        [DataMember(Order = 17)]
        public List<Image> Images { get; set; }
        [DataMember(Order = 18)]
        public List<ProductCulture> ContentList { get; set; }
        [DataMember(Order = 19)]
        public List<Parametric> Parametrics { get; set; }
        [DataMember(Order = 20)]
        public decimal? LogisticWidth { get; set; }
        [DataMember(Order = 21)]
        public decimal? LogisticHeight { get; set; }
        [DataMember(Order = 22)]
        public decimal? LogisticDepth { get; set; }
        [DataMember(Order = 23)]
        public List<SupplierProductInfo> ProductInfo { get; set; }
    }
}
