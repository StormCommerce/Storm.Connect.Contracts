using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "SkuCultureField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum SkuCultureField
    {
        [EnumMember]
        ErpName,
        [EnumMember]
        ErpNameCreateOnly,
        [EnumMember]
        Comment,
        [EnumMember]
        CommentCreateOnly,
    }
}
