using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "ParametricValueCulture", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class ParametricValueListCulture
    {
        [DataMember]
        public string CultureCode { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}
