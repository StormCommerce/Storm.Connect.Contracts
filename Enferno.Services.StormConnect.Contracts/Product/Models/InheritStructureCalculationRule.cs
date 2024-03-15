using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "InheritStructureCalculationRule", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum InheritStructureCalculationRule
    {
        [EnumMember] None = 0,
        [EnumMember] ItemsUseDefaultPriceRule = 1,
        [EnumMember] StandarPriceFromInheritedStructureItemSalePrice = 2
    }
}