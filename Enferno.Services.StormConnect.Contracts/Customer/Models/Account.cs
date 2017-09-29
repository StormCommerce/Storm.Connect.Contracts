using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Account", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Account
    {
        [DataMember]
        public Guid ApplicationKey { get; set; }
        [DataMember]
        public string LoginName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public AccountStatus Status { get; set; }
        [DataMember]
        public IEnumerable<AccountRole> Roles { get; set; }
    }
}
