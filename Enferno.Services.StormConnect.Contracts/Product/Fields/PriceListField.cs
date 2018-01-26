using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "PriceListField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum PriceListField
    {
        [EnumMember]
        Name = 0,
        [EnumMember]
        CurrencyCode = 1,
        [EnumMember]
        StartDate = 2,
        [EnumMember]
        EndDate = 3,
        [EnumMember]
        IsPublic = 4,
        [EnumMember]
        IsPrimary = 5,
        [EnumMember]
        TypeCode = 6,
        [EnumMember]
        Warehouses = 7,
        [EnumMember]
        DefaultPriceRule = 8,
        [EnumMember]
        Description = 9,
        [EnumMember]
        IsErpIntegrated = 10
    }
}
