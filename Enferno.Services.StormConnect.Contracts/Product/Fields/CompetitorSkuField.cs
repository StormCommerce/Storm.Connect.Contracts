using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "CompetitorSkuField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum CompetitorSkuField
    {
        [EnumMember]
        Source = 0,
        [EnumMember]
        CompetitorCode = 1,
        [EnumMember]
        ProductName = 2,
        [EnumMember]
        VatRate = 3,
        [EnumMember]
        ExternalPopularities = 4
    }
}
