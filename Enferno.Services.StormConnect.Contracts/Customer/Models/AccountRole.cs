using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "AccountRole", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class AccountRole
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
    }
}
