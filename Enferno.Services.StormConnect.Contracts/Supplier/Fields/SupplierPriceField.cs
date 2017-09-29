using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Supplier.Fields
{
    [DataContract(Name = "SupplierPriceField", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier.Fields")]
    public enum SupplierPriceField
    {
        [EnumMember]
        CostPurchase,
        [EnumMember]
        CostPurchaseValidTo,
        [EnumMember]
        PriceRecommended,
        [EnumMember]
        PriceMax,
        [EnumMember]
        PriceDealer,
        [EnumMember]
        IsPromotion,
        [EnumMember]
        IsFocus,
        [EnumMember]
        PriceRanking,
        [EnumMember]
        FreightCost,
        [EnumMember]
        CostFee,
        [EnumMember]
        DiscountPct,
        [EnumMember]
        IsActive,
        [EnumMember]
        PriceCatalog
    }
}
