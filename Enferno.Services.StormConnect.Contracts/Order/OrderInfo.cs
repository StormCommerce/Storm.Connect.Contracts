using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "OrderInfo", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class OrderInfo : Entity
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string Value { get; set; }
    }
}
