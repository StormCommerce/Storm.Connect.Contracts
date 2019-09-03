using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "RelationCultureField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]

    public enum RelationCultureField
    {
        [EnumMember]
        Name = 1,
        [EnumMember]
        NameCreateOnly = 2,
        [EnumMember]
        SubHeader = 3,
        [EnumMember]
        SubDescription = 4,
        [EnumMember]
        DescriptionHeader = 5,
        [EnumMember]
        Description = 6,
        [EnumMember]
        DescriptionCreateOnly = 7
    }
}
