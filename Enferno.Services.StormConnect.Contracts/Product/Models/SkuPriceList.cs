using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SkuPriceList", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class SkuPriceList
    {
        [DataMember]
        public string PartNo { get; set; }
        [DataMember]
        public string PriceListCode { get; set; }
        [DataMember]
        public int QuantityBreak { get; set; }
        [DataMember]
        public decimal PriceSale { get; set; }
        [DataMember]
        public decimal CostPurchase { get; set; }
        [DataMember]
        public decimal CostUnit { get; set; }
        [DataMember]
        public decimal? PriceRecommended { get; set; }
        [DataMember]
        public decimal? PricePrevious { get; set; }
        [DataMember]
        public decimal? PriceCatalog { get; set; }
        [DataMember]
        public bool IsPriceDiscountable { get; set; }
        [DataMember]
        public string CurrencyCode { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public PriceRule PriceRule { get; set; }
        [DataMember]
        public decimal? PriceRuleValue { get; set; }

    }
}