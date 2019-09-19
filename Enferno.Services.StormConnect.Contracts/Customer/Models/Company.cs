using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Common;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Company", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Company : ICompanyIdentifier
    {
        [DataMember]
        public Guid? ApplicationKey { get; set; }
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string OrganizationNo { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string EmailAddress { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public Image LogoImage { get; set; }
        [DataMember]
        public string ParentCompanyCode { get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
        [DataMember]
        public Address InvoiceAddress { get; set; }
        [DataMember]
        public bool? IsCustomerListDelta { get; set; }
        [DataMember]
        public IEnumerable<Address> DeliveryAddresses { get; set; }
        [DataMember]
        public IEnumerable<Info> AdditionalInfo { get; set; }
        [DataMember]
        public IEnumerable<Contact> Contacts { get; set; }
        [DataMember]
        public IEnumerable<Customer> Customers { get; set; }
        [DataMember]
        public IEnumerable<DeliveryMethod> DeliveryMethods { get; set; }
        [DataMember]
        public IEnumerable<Discount> Discounts { get; set; }
        [DataMember]
        public IEnumerable<Flag> Flags { get; set; }
        [DataMember]
        public IEnumerable<PaymentMethod> PaymentMethods { get; set; }
        [DataMember]
        public IEnumerable<PriceList> PriceLists { get; set; }
        [DataMember]
        public string VatNo { get; set; }
    }
}
