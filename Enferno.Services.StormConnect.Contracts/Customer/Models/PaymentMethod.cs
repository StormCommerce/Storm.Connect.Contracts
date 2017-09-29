using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "PaymentMethod", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class PaymentMethod
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
    }
}
