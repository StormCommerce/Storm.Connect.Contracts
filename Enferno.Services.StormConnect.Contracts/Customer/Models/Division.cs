using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Division", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Division
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public bool IsPrimary { get; set; }
    }
}
