using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "ExternalContentParametricGroup", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class ExternalContentParametricGroup
    {
        public ExternalContentParametricGroup()
        {
            Translations = new List<ExternalContentParametricGroupCulture>();
        }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public IList<ExternalContentParametricGroupCulture> Translations { get; set; }
    }
}