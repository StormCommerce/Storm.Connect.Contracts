using System;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Header", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Header
    {
        [DataMember(Order = 1)]
        public Guid? ApplicationKey { get; set; }
    }
}
