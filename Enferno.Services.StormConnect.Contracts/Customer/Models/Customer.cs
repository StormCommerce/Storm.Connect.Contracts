using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Customer", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Customer
    {
        [DataMember]
        public CustomerType Type { get; set; }
        [DataMember]
        public Guid? ApplicationKey { get; set; }
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public string SocialSecurityNumber { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string MiddleName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public string CellPhoneNumber { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public Address InvoiceAddress { get; set; }
        [DataMember]
        public IEnumerable<Address> DeliveryAddresses { get; set; }
        [DataMember]
        public IEnumerable<Account> Accounts { get; set; }
        [DataMember]
        public IEnumerable<Info> AdditionalInfo { get; set; }
        [DataMember]
        public IEnumerable<Flag> Flags { get; set; }
        [DataMember]
        public IEnumerable<PriceList> PriceLists { get; set; }
    }
}
