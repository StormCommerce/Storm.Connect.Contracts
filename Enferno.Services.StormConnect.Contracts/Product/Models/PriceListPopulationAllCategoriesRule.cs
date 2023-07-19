using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulationAllCategoriesRule", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum PriceListPopulationAllCategoriesRule
    {
        [EnumMember] None = 1,
        [EnumMember] Manufacturers = 2,
        [EnumMember] Flags = 3
    }
}