
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "VatRate", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class VatRate
    {
        [DataMember]
        public SalesArea? SalesArea { get; set; }
        /// <summary>
        /// Vat rate in percentage. E.g value 25.00 is equivalent to 25% vat rate
        /// </summary>
        [DataMember]
        public decimal? Rate { get; set; }
    }
}
