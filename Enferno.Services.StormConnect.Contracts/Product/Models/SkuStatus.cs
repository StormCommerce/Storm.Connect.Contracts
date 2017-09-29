using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SkuStatus", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum SkuStatus
    {
        [EnumMember]
        Active = 1,
        [EnumMember]
        Coming = 2,
        [EnumMember]
        Expiring = 3,
        [EnumMember]
        Hidden = 4,
        [EnumMember]
        Inactive = 5,
        [EnumMember]
        NotActivated = 6,
    }
}