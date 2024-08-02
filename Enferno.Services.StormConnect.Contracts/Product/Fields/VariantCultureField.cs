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
        [EnumMember]
        UniqueUrlName = 4,
        [EnumMember]
        IsUniqueUrlNameManuallyMaintained = 5,
        [EnumMember]
        UniqueUrlNameCreateOnly = 6,
        [EnumMember]
        SubHeader = 7,
        [EnumMember]
        SubDescription = 8,
        [EnumMember]
        DescriptionHeader = 9,
        [EnumMember]
        Description = 10,
        [EnumMember]
        DescriptionCreateOnly = 11,
        [EnumMember]
        Synonyms = 12,
        [EnumMember]
        Title = 13,
        [EnumMember]
        Tags = 14,
        [EnumMember]
        MetaTags = 15,
        [EnumMember]
        MetaDescription = 16
    }
}
