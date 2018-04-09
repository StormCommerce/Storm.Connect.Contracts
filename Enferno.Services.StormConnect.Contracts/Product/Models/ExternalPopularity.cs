using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "ExternalPopularity", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class ExternalPopularity
    {
        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public string PartNo { get; set; }
        [DataMember]
        public decimal PopularityValue { get; set; }
    }
}
