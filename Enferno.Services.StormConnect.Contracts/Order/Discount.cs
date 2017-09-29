using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Discount", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Discount
    {
        [DataMember(Order = 1)]
        public string Type { get; set; }
        [DataMember(Order = 2)]
        public string Code { get; set; }
        [DataMember(Order = 3)]
        public decimal Amount { get; set; }
    }
}