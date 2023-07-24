using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulationCategory", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class PriceListPopulationCategory
    {
        [DataMember(IsRequired = true)]
        public string Code { get; set; }

        [DataMember(IsRequired = true)]
        public PriceListPopulationCategoryRuleType RuleType { get; set; }

        [DataMember]
        public IEnumerable<string> RuleCodes { get; set; }

        [DataMember]
        public bool? RequireSupplier { get; set; } = false;
    }
}