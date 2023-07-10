using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PopulationRulesType", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum PopulationRulesType
    {
        [EnumMember]
        Exclude = 0,

        [EnumMember]
        Include = 1
    }
}