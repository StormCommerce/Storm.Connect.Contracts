using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "ParametricValueCulture", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class ParametricValueCulture
    {
        [DataMember]
        public string CultureCode { get; set; }
        [DataMember]
        public string ValueText { get; set; }
    }
}
