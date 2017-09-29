using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "VariantDefinitionType", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class VariantDefinitionType
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int SortOrder { get; set; }
        [DataMember]
        public string ParametricCode { get; set; }
    }
}