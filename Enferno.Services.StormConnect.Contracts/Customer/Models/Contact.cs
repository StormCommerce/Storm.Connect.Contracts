using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Contact", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Contact
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
    }
}
