using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "RelationField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]

    public enum RelationField
    {
        [EnumMember]
        IsVariantUnique = 1,
        [EnumMember]
        IsVariantUniqueCreateOnly = 2,
        [EnumMember]
        IsRelatedVariantUnique = 3,
        [EnumMember]
        IsRelatedVariantUniqueCreateOnly = 4,
        [EnumMember]
        Cultures = 5
    }
}
