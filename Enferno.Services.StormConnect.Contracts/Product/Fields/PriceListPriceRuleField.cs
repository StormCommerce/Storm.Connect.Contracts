using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "PriceListPriceRuleField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum PriceListPriceRuleField
    {
        [EnumMember] Type = 0,
        [EnumMember] Value = 1,
        [EnumMember] LimitToRecPrice = 2,
        [EnumMember] MinValue = 3,
        [EnumMember] MaxValue = 4,
        [EnumMember] ManufacturerCode = 5,
        [EnumMember] CategoryCode = 6,
        [EnumMember] Flags = 7,
        [EnumMember] SupplementalChargeFixed = 8,
        [EnumMember] SupplementalChargePercent = 9
    }
}
