using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "ImageCultureField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum ImageCultureField
    {
        [EnumMember] Name = 0,
        [EnumMember] Description = 1,
        [EnumMember] AltText = 2
    }
}
