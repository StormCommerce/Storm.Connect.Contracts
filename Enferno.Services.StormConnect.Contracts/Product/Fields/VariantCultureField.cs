using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "VariantCultureField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum VariantCultureField
    {
        [EnumMember]
        CultureCode = 0,
        [EnumMember]
        Name = 1,
        [EnumMember]
        NameCreateOnly = 2,
        [EnumMember]
        NameLimitedUpdate = 3,
    }
}
