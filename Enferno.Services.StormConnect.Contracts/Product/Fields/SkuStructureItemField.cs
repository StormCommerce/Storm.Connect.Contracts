using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "SkuStructureItemField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum SkuStructureItemField
    {
        [EnumMember]
        SortOrder = 0,
        [EnumMember]
        StandardStructureItemPrice = 1,
        [EnumMember]
        AdditionalInfo = 2,
    }
}
