using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "WarehouseType", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum WarehouseType
    {
        [EnumMember]
        Warehouse = 1,
        [EnumMember]
        Store = 2,
        [EnumMember]
        Transport = 3,
        [EnumMember]
        Other = 4,
    }
}