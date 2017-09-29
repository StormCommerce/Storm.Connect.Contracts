using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "ExternalContentParametricGroupCulture", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class ExternalContentParametricGroupCulture
    {
        [DataMember]
        public string CultureCode { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}