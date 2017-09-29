using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Company", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Company 
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string VatNo { get; set; }
        [DataMember(Order = 4)]
        public string Phone { get; set; }
        [DataMember(Order = 5)]
        public string Fax { get; set; }
        [DataMember(Order = 6)]
        public string Email { get; set; }
        [DataMember(Order = 7)]
        public Addresses Addresses { get; set; }
        [DataMember(Order = 8)]
        public PricelistCodeList PricelistCodes { get; set; }
        [DataMember(Order = 9)]
        public bool PricelistLimit { get; set; }
        [DataMember(Order = 10)]
        public PaymentCodeList PaymentCodes { get; set; }
        [DataMember(Order = 11)]
        public bool PaymentCodeLimit { get; set; }
        [DataMember(Order = 12)]
        public DeliveryCodeList DeliveryCodes { get; set; }
        [DataMember(Order = 13)]
        public bool DeliveryCodeLimit { get; set; }
        [DataMember(Order = 14)]
        public bool? IsActive { get; set; }
        [DataMember(Order = 15)]
        public CodeValues AdditionalInfo { get; set; }
    }
}