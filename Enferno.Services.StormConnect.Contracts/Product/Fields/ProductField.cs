using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "ProductField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum ProductField
    {
        [EnumMember]
        ManufacturerCode = 0,
        [EnumMember]
        ManufacturerName = 1,
        [EnumMember]
        Alias = 2,
        [EnumMember]
        Code = 3,
        [EnumMember]
        Variants = 4,
        [EnumMember]
        Cultures = 5,
        [EnumMember]
        Categories = 6,
        [EnumMember]
        MainImage = 7,
        [EnumMember]
        AdditionalImages = 8,
        [EnumMember]
        Family = 9,
        [EnumMember]
        ProductParametrics = 10,
        [EnumMember]
        ProductParametricsCreateOnly = 11,
        [EnumMember]
        VariantDefinitionGroup = 12,
        [EnumMember]
        VariantDefinitionGroupCreateOnly = 13,
        [EnumMember]
        Assortment = 14,
        [EnumMember]
        UniqueUrlName = 15,
        [EnumMember]
        IsUniqueUrlNameManuallyMaintained = 16
    }
}
