using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "WarehouseLocationField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum WarehouseLocationField
    {
        [EnumMember]
        Name = 0,
        [EnumMember]
        LeadTimeDayCount = 1,
        [EnumMember]
        IsIncludedInStockCalculation = 2,
    }
}
