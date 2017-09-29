using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "PriceList", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class PriceList
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public bool IsExclusive { get; set; }
    }
}
