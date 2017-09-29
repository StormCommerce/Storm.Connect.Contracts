using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Customer", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Customer 
    {
        [DataMember(Order = 1)]
        public string CustomerCode { get; set; }
        [DataMember(Order = 2)]
        public string CompanyCode { get; set; }
        [DataMember(Order = 3)]
        public string FirstName { get; set; }
        [DataMember(Order = 4)]
        public string LastName { get; set; }
        [DataMember(Order = 5)]
        public string JobTitle { get; set; }
        [DataMember(Order = 6)]
        public string PrivatePhone { get; set; }
        [DataMember(Order = 7)]
        public string CellPhone { get; set; }
        [DataMember(Order = 8)]
        public string WorkPhone { get; set; }
        [DataMember(Order = 9)]
        public string Email { get; set; }
        [DataMember(Order = 10)]
        public string SSN { get; set; }
        [DataMember(Order = 11)]
        public Address Address { get; set; }
        [DataMember(Order = 12)]
        public CodeValues AdditionalInfo { get; set; }
        [DataMember(Order = 13)]
        public bool? IsActive { get; set; }
    }
}