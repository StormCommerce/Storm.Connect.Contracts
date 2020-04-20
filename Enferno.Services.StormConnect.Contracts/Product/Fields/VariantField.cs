using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "VariantField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum VariantField
    {
        [EnumMember]
        ManufacturerPartNo = 0,
        [EnumMember]
        SortOrderValue = 1,
        [EnumMember]
        StockDisplayBreakPoint = 2,
        [EnumMember]
        IsDangerousGoods = 3,
        [EnumMember]
        Cultures = 4,
        [EnumMember]
        Skus = 5,
        [EnumMember]
        MainImage = 6,
        [EnumMember]
        AdditionalImages = 7,
        [EnumMember]
        VariantParametrics = 8,
        [EnumMember]
        VariantParametricsCreateOnly = 9,
        [EnumMember]
        NonParametricVariantDefinitions = 10,
        [EnumMember]
        NonParametricVariantDefinitionsCreateOnly = 11,
        [EnumMember]
        DeliveryMethods = 12,
        [EnumMember]
        DeliveryMethodsCreateOnly = 13,
        [EnumMember]
        AdditionalImagesCleanup = 14,
        [EnumMember]
        ParametricsCleanup = 15,
        [EnumMember]
        TranslationRequested = 16
    }
}
