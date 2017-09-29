using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "AccountStatus", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public enum AccountStatus
    {
        [EnumMember]
        Active = 1,
        [EnumMember]
        Inactive = 2,
    }
}
