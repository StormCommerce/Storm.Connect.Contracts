using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "ExternalContentParametricCulture", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class ExternalContentParametricCulture
    {
        [DataMember]
        public string CultureCode { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Uom { get; set; }
    }
}