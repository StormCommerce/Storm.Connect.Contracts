using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "PriceListPriceRuleField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum PriceListPriceRuleField
    {
        [EnumMember] Type = 0,
        [EnumMember] Value = 1,
        [EnumMember] LimitToRecPrice = 2,
        [EnumMember] SupplementalChargeFixed = 3,
        [EnumMember] SupplementalChargePercent = 4,
        [EnumMember] InheritStructureCalculationRule = 5,
    }
}