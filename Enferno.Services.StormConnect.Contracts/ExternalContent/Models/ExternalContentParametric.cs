using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Common;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "ExternalContentParametric", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class ExternalContentParametric
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Uom { get; set; }
        [DataMember]
        public ParametricType ParametricType { get; set; }
        [DataMember]
        public bool HasListValues { get; set; }
        [DataMember]
        public bool HasMultipleValues { get; set; }
        [DataMember]
        public IList<ExternalContentParametricCulture> Translations { get; set; }
        [DataMember]
        public IList<string> ExampleValues { get; set; }
    }
}