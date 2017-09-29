using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "VariantDefinition", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class VariantDefinition
    {
        [DataMember]
        public string TypeCode { get; set; }
        [DataMember]
        public IEnumerable<VariantDefinitionCulture> Cultures { get; set; }
    }
}