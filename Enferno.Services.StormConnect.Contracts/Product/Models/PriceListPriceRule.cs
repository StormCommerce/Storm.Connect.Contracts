using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPriceRule", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class PriceListPriceRule
    {
        [DataMember]
        public PriceListPriceRuleType Type { get; set; }

        [DataMember]
        public decimal Value { get; set; }

        [DataMember]
        public bool? LimitToRecPrice { get; set; }

        [DataMember]
        public decimal? MinValue { get; set; }

        [DataMember]
        public decimal? MaxValue { get; set; }

        [DataMember]
        public string ManufacturerCode { get; set; }

        [DataMember]
        public string CategoryCode { get; set; }

        [DataMember]
        public IEnumerable<string> Flags { get; set; }

        [DataMember]
        public decimal? SupplementalChargeFixed { get; set; }

        [DataMember]
        public decimal? SupplementalChargePercent { get; set; }
    }
}