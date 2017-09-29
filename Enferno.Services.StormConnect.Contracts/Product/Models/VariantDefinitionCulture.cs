using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "VariantDefinitionCulture", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class VariantDefinitionCulture
    {
        [DataMember]
        public string CultureCode { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
}
