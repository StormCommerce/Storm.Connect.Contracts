using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulationType", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum PriceListPopulationType
    {
        [EnumMember] Exclude = 1,
        [EnumMember] Include = 2,
        [EnumMember] IncludeRequireSupplier = 3
    }
}