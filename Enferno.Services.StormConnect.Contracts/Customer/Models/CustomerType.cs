using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "CustomerType", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public enum CustomerType
    {
        [EnumMember]
        Customer = 1,
        [EnumMember]
        CompanyContact = 2,
    }
}
