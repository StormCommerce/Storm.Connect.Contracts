using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulationAllCategories", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class PriceListPopulationAllCategories
    {
        [DataMember(IsRequired = true)]
        public PriceListPopulationAllCategoriesRule Rule { get; set; }

        [DataMember]
        public IEnumerable<string> RuleCodes { get; set; } = new List<string>();
    }
}