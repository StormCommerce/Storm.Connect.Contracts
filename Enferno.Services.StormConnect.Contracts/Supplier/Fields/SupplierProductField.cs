using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Supplier.Fields
{
    [DataContract(Name = "SupplierProductField", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier.Fields")]
    public enum SupplierProductField
    {
        [EnumMember]
        SupplierPartNo,
        [EnumMember]
        ProductName,
        [EnumMember]
        CategoryCode,
        [EnumMember]
        ProductType,
        [EnumMember]
        Manufacturer,
        [EnumMember]
        ManufacturerPartNo,
        [EnumMember]
        EanCode,
        [EnumMember]
        CommodityCode,
        [EnumMember]
        GrossWeight,
        [EnumMember]
        NetWeight,
        [EnumMember]
        UnitOfMeasurementCode,
        [EnumMember]
        UnitOfMeasurementCount,
        [EnumMember]
        VatCode,
        [EnumMember]
        LogisticWidth,
        [EnumMember]
        LogisticHeight,
        [EnumMember]
        LogisticDepth,
    }
}