using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "CompetitorSku", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class CompetitorSku
    {
        [DataMember]
        public string PartNo { get; set; }
        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public string CompetitorCode { get; set; }
        [DataMember]
        public string CompetitorName { get; set; }
        [DataMember]
        public string CompetitorPartNo { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string CurrencyCode { get; set; }
        [DataMember]
        public decimal PriceSale { get; set; }
        [DataMember]
        public decimal PriceSaleInclFreight { get; set; }
        [DataMember]
        public bool IsPricesInclVat { get; set; }
        [DataMember]
        public decimal? VatRate { get; set; }
        [DataMember]
        public bool IsInStock { get; set; }
        [DataMember]
        public IEnumerable<ExternalPopularity> ExternalPopularities { get; set; }
    }
}
