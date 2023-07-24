using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulationCategoryRule", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum PriceListPopulationCategoryRuleType
    {
        [EnumMember] None = 1,
        [EnumMember] Manufacturers = 2,
        [EnumMember] Flags = 3,
        [EnumMember] Category = 4
    }
}