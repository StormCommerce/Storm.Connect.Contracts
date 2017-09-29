using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "VariantDefinitionGroup", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class VariantDefinitionGroup
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public IEnumerable<VariantDefinitionType> Types { get; set; }
    }
}