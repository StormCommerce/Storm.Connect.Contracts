using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "WarehouseField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum WarehouseField
    {
        [EnumMember]
        Type = 0,
        [EnumMember]
        Name = 1,
        [EnumMember]
        LeadTimeDayCount = 2,
    }
}
