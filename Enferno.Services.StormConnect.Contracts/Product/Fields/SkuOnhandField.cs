using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "SkuOnhandField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum SkuOnhandField
    {
        //[EnumMember]
        //PartNo,
        //[EnumMember]
        //LocationCode,
        //[EnumMember]
        //WarehouseCode,
        [EnumMember]
        OnhandValue= 3,
        [EnumMember]
        IncomingValue = 4,
        [EnumMember]
        NextDeliveryDate = 5,
        [EnumMember]
        LeadTimeDayCount = 6,
        [EnumMember]
        OnOrderValue = 7,
        [EnumMember]
        MinimumValue = 8,
        [EnumMember]
        MaximumValue = 9,
        [EnumMember]
        IsActive = 10,
        [EnumMember]
        Infos = 11
    }
}
