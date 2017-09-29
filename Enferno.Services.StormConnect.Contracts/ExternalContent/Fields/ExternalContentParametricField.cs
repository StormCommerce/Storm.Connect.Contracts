using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Fields
{
    [DataContract(Name = "ExternalContentParametricField", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Fields")]
    public enum ExternalContentParametricField
    {
        [EnumMember]
        Name,
        [EnumMember]
        Uom,
        [EnumMember]
        ParametricType,
        [EnumMember]
        HasListValues,
        [EnumMember]
        HasMultipleValues,
        [EnumMember]
        ExampleValues,
    }
}