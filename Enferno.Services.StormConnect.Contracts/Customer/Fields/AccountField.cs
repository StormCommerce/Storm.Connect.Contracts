using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Fields
{
    [DataContract(Name = "AccountField", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Fields")]
    public enum AccountField
    {
        [EnumMember]
        PasswordCreateOnly = 0,
        [EnumMember]
        Status = 1,
        [EnumMember]
        StatusCreateOnly = 2,
        [EnumMember]
        Roles = 3,
        [EnumMember]
        RolesCreateOnly = 4,
    }
}
