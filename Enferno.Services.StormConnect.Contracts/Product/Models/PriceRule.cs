using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceRule", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum PriceRule
    {
        [EnumMember]
        CostPlus_PurchaseCost = 1,
        [EnumMember]
        FixedPrice = 2,
        [EnumMember]
        Margin_PurchaseCost = 3,
        [EnumMember]
        UseRecommendedPrice = 4,
        [EnumMember]
        CostPlus_UnitCost = 5,
        [EnumMember]
        Margin_UnitCost = 6,
        [EnumMember]
        UseStandardPrice_PctDiscount = 7,
        [EnumMember]
        Competitive_PurchaseCost = 8,
        [EnumMember]
        Competitive_UnitCost = 9,
        [EnumMember]
        UseStandardPrice_FixedDiscount = 10,
        [EnumMember]
        StructureCalculation = 11,
        [EnumMember]
        UseCatalogPrice = 12
    }
}
