using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Supplier.Fields
{
    [DataContract(Name = "SupplierOnHandField", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier.Fields")]
    public enum SupplierOnHandField
    {
        [EnumMember]
        Value,
        [EnumMember]
        IncomingValue,
        [EnumMember]
        NextDeliveryDate,
        [EnumMember]
        StoppedDate,
        [EnumMember]
        IsReturnable,
        [EnumMember]
        LeadTimeDayCount,
        [EnumMember]
        ExternalStockValue,
        [EnumMember]
        PackageValue,
        [EnumMember]
        MinimumOrderValue,
        [EnumMember]
        IsActive,
    }
}