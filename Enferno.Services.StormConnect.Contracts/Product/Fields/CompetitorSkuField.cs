using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "CompetitorSkuField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum CompetitorSkuField
    {
        [EnumMember]
        CompetitorName = 0,
        [EnumMember]
        ProductName = 1,
        [EnumMember]
        VatRate = 2,
        [EnumMember]
        ExternalPopularities = 3
    }
}
