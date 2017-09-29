using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "DeliveryMethod", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class DeliveryMethod
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
    }
}
