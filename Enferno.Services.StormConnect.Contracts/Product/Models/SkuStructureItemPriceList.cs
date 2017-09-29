using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SkuStructureItemPriceList", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class SkuStructureItemPriceList
    {
        [DataMember]
        public string StructurePartNo { get; set; }
        [DataMember]
        public string PartNo { get; set; }
        [DataMember]
        public string PriceListCode { get; set; }
        [DataMember]
        public string ItemPriceListCode { get; set; }
        [DataMember]
        public int QuantityBreak { get; set; }
        [DataMember]
        public decimal PriceSale { get; set; }
        [DataMember]
        public string CurrencyCode { get; set; }
    }
}