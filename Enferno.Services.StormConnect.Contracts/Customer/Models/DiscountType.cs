using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "DiscountType", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public enum DiscountType
    {
        [EnumMember]
        Category = 1,
        [EnumMember]
        ProductDiscountClass = 2,
    }
}
