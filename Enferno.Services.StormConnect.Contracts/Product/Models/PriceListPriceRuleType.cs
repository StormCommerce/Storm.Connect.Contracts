using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    /// <summary>
    /// FixedPrice, Competitive_PurchaseCost, Competitive_UnitCost and StructureCalculation has been removed from this enum.
    /// They still exist in the PriceRule enum for backward compatibility.
    /// </summary>
    [DataContract(Name = "PriceListPriceRuleType", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum PriceListPriceRuleType
    {
        [EnumMember]
        CostPlus_PurchaseCost = 1,
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
        UseStandardPrice_FixedDiscount = 10,
        [EnumMember]
        UseCatalogPrice = 12
    }
}