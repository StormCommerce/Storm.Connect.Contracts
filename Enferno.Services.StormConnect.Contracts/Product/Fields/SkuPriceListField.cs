using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "SkuPriceListField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum SkuPriceListField
    {
        //[EnumMember]
        //PartNo,
        //[EnumMember]
        //PriceListCode,
        //[EnumMember]
        //QuantityBreak,
        [EnumMember]
        PriceSale = 3,
        [EnumMember]
        CostPurchase = 4,
        [EnumMember]
        CostUnit = 5,
        [EnumMember]
        PriceRecommended = 6,
        [EnumMember]
        PricePrevious = 7,
        [EnumMember]
        PriceCatalog = 8,
        [EnumMember]
        IsPriceDiscountable = 9,
        [EnumMember]
        IsActive = 10,
        [EnumMember]
        IsPriceDiscountableCreateOnly = 11,
        [EnumMember]
        PriceRule = 12
    }
}
