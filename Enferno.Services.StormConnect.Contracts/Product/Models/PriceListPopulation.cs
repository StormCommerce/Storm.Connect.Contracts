using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulation", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class PriceListPopulation
    {
        [DataMember]
        public PriceListPopulationType? Type { get; set; }

        [DataMember]
        public PriceListPopulationAllCategories AllCategories { get; set; }

        [DataMember]
        public IEnumerable<PriceListPopulationCategory> Categories { get; set; } = new List<PriceListPopulationCategory>();

        [DataMember]
        public bool? RequiredSupplier { get; set; }
    }
}