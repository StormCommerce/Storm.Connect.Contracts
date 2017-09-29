using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Promotion", Namespace = "Enferno.Services.Contracts.StormConnect.Order")]
    public class Promotion 
    {
        [DataMember(Order = 1)]
        public string Id { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string DiscountCode { get; set; }
        [DataMember(Order = 4)]
        public decimal AppliedAmount { get; set; }
    }
}