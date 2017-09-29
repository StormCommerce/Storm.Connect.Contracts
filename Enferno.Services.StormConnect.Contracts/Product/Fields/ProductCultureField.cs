using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "ProductCultureField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum ProductCultureField
    {
        [EnumMember]
        Name = 0,
        [EnumMember]
        NameCreateOnly = 1,
        [EnumMember]
        SubHeader = 2,
        [EnumMember]
        SubDescription = 3,
        [EnumMember]
        DescriptionHeader = 4,
        [EnumMember]
        Description = 5,
        [EnumMember]
        DescriptionCreateOnly = 6,
        [EnumMember]
        Synonyms = 7,
        [EnumMember]
        Title = 8,
        [EnumMember]
        Tags = 9,
        [EnumMember]
        MetaTags = 10,
        [EnumMember]
        MetaDescription = 11,
        [EnumMember]
        NameLimitedUpdate = 12,
    }
}