using System;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Flag", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Flag
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public DateTime? StopDate { get; set; }
        [DataMember] 
        public bool? IsCreateOnly { get; set; }
        [DataMember] 
        public bool? IsLimitedUpdate { get; set; }

    }
}
