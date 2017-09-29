using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Info", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Info
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Value { get; set; }
    }
}
