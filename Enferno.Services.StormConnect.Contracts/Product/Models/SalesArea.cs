
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SalesArea", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum SalesArea
    {
        [EnumMember]
        Sweden = 1,
        [EnumMember]
        Norway = 2,
        [EnumMember]
        Denmark = 3,
        [EnumMember]
        Finland = 4,
        [EnumMember]
        UnitedKingdom = 5,
        [EnumMember]
        Estonia = 6,
        [EnumMember]
        Greenland = 7,
        [EnumMember]
        Germany = 8,
        [EnumMember]
        Italy = 9,
        [EnumMember]
        Austria = 10,
        [EnumMember]
        Spain = 11,
        [EnumMember]
        Netherlands = 12,
        [EnumMember]
        Belgium = 13,
        [EnumMember]
        France = 14,
        [EnumMember]
        Switzerland = 15,
        [EnumMember]
        USA = 17,
        [EnumMember]
        Ireland = 18,
        [EnumMember]
        Canada = 19,
    }
}
