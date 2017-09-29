using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Fields
{
    [DataContract(Name = "ExternalContentCategoryField", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Fields")]
    public enum ExternalContentCategoryField
    {
        [EnumMember]
        CategoryName,
        [EnumMember]
        CategoryFullName,
        UnspcCode,
        [EnumMember]
        ParentCategoryCode,
        [EnumMember]
        HasRequirements,
        [EnumMember]
        IsHidden,        
    }
}