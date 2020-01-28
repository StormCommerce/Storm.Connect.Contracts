using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "SkuField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum SkuField
    {
        //[EnumMember]
        //PartNo,
        [EnumMember]
        Status = 1,
        [EnumMember]
        Type = 2,
        [EnumMember]
        IntegrationPartNo = 3,
        [EnumMember]
        CommodityCode = 4,
        [EnumMember]
        EanCode = 5,
        [EnumMember]
        TrackingCode = 6,
        [EnumMember]
        UnitOfMeasurementType = 7,
        [EnumMember]
        UnitOfMeasurementCount = 8,
        [EnumMember]
        IsDropShipOnly = 9,
        [EnumMember]
        IsBuyable = 10,
        [EnumMember]
        DiscountClass = 11,
        [EnumMember]
        RecommendedSalesQty = 12,
        [EnumMember]
        IsRecommendedSalesQtyFixed = 13,
        [EnumMember]
        ActualWeight = 14,
        [EnumMember]
        VolumeWeight = 15,
        [EnumMember]
        LogisticWidth = 16,
        [EnumMember]
        LogisticHeight = 18,
        [EnumMember]
        LogisticDepth = 19,
        [EnumMember]
        StandardPrice = 20,
        [EnumMember]
        VatRate = 21,
        [EnumMember]
        StatusCreateOnly = 22,
        [EnumMember]
        StartDate = 23,
        [EnumMember]
        StopDate = 24,
        [EnumMember]
        StructureItems = 25,
        [EnumMember]
        PartNoCreateWhenMissing = 26
    }
}
