using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "UnitMeasurementType", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum UnitMeasurementType
    {
        [EnumMember]
        Pieces = 1,
        [EnumMember]
        Hour = 2,
        [EnumMember]
        Kilogram = 3,
        [EnumMember]
        Litre = 4,
        [EnumMember]
        Pair = 5,
        [EnumMember]
        SquareMeter = 6,
        [EnumMember]
        Meter = 7
    }
}
