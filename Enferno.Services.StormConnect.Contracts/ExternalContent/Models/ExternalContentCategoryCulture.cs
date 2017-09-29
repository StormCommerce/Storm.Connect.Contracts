using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "ExternalContentCategoryCulture", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class ExternalContentCategoryCulture
    {
        [DataMember]
        public string CultureCode { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public string CategoryFullName { get; set; }
    }
}