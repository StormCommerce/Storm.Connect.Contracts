using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceListPopulationRule", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class PriceListPopulationRule
    {
        [DataMember]
        public string ManufacturerCode { get; set; }

        [DataMember]
        public string CategoryCode { get; set; }

        [DataMember]
        public IEnumerable<string> Flags { get; set; }

        [DataMember]
        public bool? SupplierRequired { get; set; }
    }
}