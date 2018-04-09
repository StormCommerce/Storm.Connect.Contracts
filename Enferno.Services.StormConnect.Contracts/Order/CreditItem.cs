using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "CreditItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class CreditItem : Entity
    {
        [DataMember(Order = 1)]
        public string LineNo { get; set; }
        [DataMember(Order = 2)]
        public string PartNo { get; set; }
        [DataMember(Order = 3)]
        public string ProductName { get; set; }
        [DataMember(Order = 4)]
        public string ProductDescription { get; set; }
        [DataMember(Order = 5)]
        public int Quantity { get; set; }
        [DataMember(Order = 6)]
        public decimal UnitPrice { get; set; }
        [DataMember(Order = 7)]
        public decimal UnitVat { get; set; }
        [DataMember(Order = 8)]
        public decimal VatRate { get; set; }
    }
}
