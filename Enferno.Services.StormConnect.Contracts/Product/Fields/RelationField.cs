using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "RelationField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]

    public enum RelationField
    {
        [EnumMember]
        IsActive = 1,
        [EnumMember]
        IsVariantUnique = 2,
        [EnumMember]
        IsVariantUniqueCreateOnly = 3,
        [EnumMember]
        IsRelatedVariantUnique = 4,
        [EnumMember]
        IsRelatedVariantUniqueCreateOnly = 5,
        [EnumMember]
        DefaultName = 6,
        [EnumMember]
        DefaultSubHeader = 7,
        [EnumMember]
        DefaultSubDescription = 8,
        [EnumMember]
        DefaultDescriptionHeader = 9,
        [EnumMember]
        DefaultDescription = 10,
        [EnumMember]
        Cultures = 11,
        [EnumMember]
        SortOrder = 12
    }
}
