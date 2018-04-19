using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Payment", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Payment : Entity
    {
        [DataMember(Order = 1)]
        public int PaymentCode { get; set; }
        [DataMember(Order = 2)]
        public string PaymentMethodCode { get; set; }
        [DataMember(Order = 3)]
        public string PaymentRef { get; set; }
        [DataMember(Order = 4)]
        public decimal Amount { get; set; }
        [DataMember(Order = 5)]
        public string CurrencyCode { get; set; }
        [DataMember(Order = 6)]
        public CodeValues AdditionalInfo { get; set; }
    }
}
