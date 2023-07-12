using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulationCategoryRule", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum PriceListPopulationCategoryRule
    {
        [EnumMember] Manufacturers = 1,
        [EnumMember] Flags = 2,
        [EnumMember] Category = 3
    }
}