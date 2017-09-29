using System;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Supplier.Models
{
    [DataContract(Name = "SupplierPrice", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier.Models")]
    public class SupplierPrice
    {
        public SupplierPrice()
        {
            QtyBreak = 1;
        }
        [DataMember(Order = 1)]
        public string PriceListCode { get; set; }
        [DataMember(Order = 2)]
        public int QtyBreak { get; set; }
        [DataMember(Order = 3)]
        public string CurrencyCode { get; set; }
        [DataMember(Order = 4)]
        public decimal CostPurchase { get; set; }
        [DataMember(Order = 5)]
        public DateTime? CostPurchaseValidTo { get; set; }
        [DataMember(Order = 6)]
        public decimal? PriceRecommended { get; set; }
        [DataMember(Order = 7)]
        public decimal? PriceMax { get; set; }
        [DataMember(Order = 8)]
        public decimal? PriceDealer { get; set; }
        [DataMember(Order = 9)]
        public bool? IsPromotion { get; set; }
        [DataMember(Order = 10)]
        public bool? IsFocus { get; set; }
        [DataMember(Order = 11)]
        public int? PriceRanking { get; set; }
        [DataMember(Order = 12)]
        public decimal? FreightCost { get; set; }
        [DataMember(Order = 13)]
        public decimal? CostFee { get; set; }
        [DataMember(Order = 14)]
        public decimal? DiscountPct { get; set; }
        [DataMember(Order = 15)]
        public bool IsActive { get; set; }
        [DataMember(Order = 16)]
        public decimal? PriceCatalog { get; set; }
    }
}
