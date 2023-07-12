using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulationAllCategoriesRule", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum PriceListPopulationAllCategoriesRule
    {
        [EnumMember] Manufacturers = 1,
        [EnumMember] Flags = 2
    }
}