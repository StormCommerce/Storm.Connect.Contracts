using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Fields
{
    [DataContract(Name = "CompanyField", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Fields")]
    public enum CompanyField
    {
        [EnumMember]
        ApplicationKey = 0,
        [EnumMember]
        Id = 1,
        [EnumMember]
        Code = 2,
        [EnumMember]
        OrganizationNo = 3,
        [EnumMember]
        Name = 4,
        [EnumMember]
        EmailAddress = 5,
        [EnumMember]
        PhoneNumber = 6,
        [EnumMember]
        LogoImage = 7,
        [EnumMember]
        ParentCompanyCode = 8,
        [EnumMember]
        IsActive = 9,
        [EnumMember]
        InvoiceAddress = 10,
        [EnumMember]
        DeliveryAddresses = 11,
        [EnumMember]
        AdditionalInfo = 12,
        [EnumMember]
        Contacts = 13,
        [EnumMember]
        Customers = 14,
        [EnumMember]
        DeliveryMethods = 15,
        [EnumMember]
        Discounts = 16,
        [EnumMember]
        Flags = 17,
        [EnumMember]
        PaymentMethods = 18,
        [EnumMember]
        PriceLists = 19,
        [EnumMember]
        SearchOnlyByCode = 20,
        [EnumMember]
        VatNo = 21,
        [EnumMember]
        PreserveFlags = 22
    }
}
