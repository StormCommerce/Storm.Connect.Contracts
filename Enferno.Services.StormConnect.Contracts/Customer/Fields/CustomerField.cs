using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Fields
{
    [DataContract(Name = "CustomerField", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Fields")]
    public enum CustomerField
    {
        [EnumMember]
        ApplicationKey = 0,
        [EnumMember]
        Id = 1,
        [EnumMember]
        Code = 2,
        [EnumMember]
        EmailAddress = 3,
        [EnumMember]
        SocialSecurityNumber = 4,
        [EnumMember]
        Title = 5,
        [EnumMember]
        FirstName = 6,
        [EnumMember]
        MiddleName = 7,
        [EnumMember]
        LastName = 8,
        [EnumMember]
        PhoneNumber = 9,
        [EnumMember]
        CellPhoneNumber = 10,
        [EnumMember]
        IsActive = 11,
        [EnumMember]
        InvoiceAddress = 12,
        [EnumMember]
        DeliveryAddresses = 13,
        [EnumMember]
        Accounts = 14,
        [EnumMember]
        AdditionalInfo = 15,
        [EnumMember]
        Flags = 16,
        [EnumMember]
        PriceLists = 17,
        [EnumMember]
        SearchOnlyByCode = 18,
        [EnumMember]
        Companies = 19,
        [EnumMember]
        CrmId = 20,
        [EnumMember]
        PreserveFlags = 21
    }
}
