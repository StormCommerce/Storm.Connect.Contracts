using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "ClientCustomer", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class ClientCustomer
    {
        [DataMember(Order = 1)]
        public Company Company { get; set; }
        [DataMember(Order = 2)]
        public Customer Person { get; set; }
    }
}