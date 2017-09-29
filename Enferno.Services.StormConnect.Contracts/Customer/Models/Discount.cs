using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Discount", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Discount
    {
        [DataMember]
        public DiscountType Type { get; set; }
        [DataMember]
        public string ValueCode { get; set; }
        [DataMember]
        public decimal DiscountPercentage { get; set; }
        [DataMember]
        public string PriceListTypeIdSeed { get; set; }
    }
}
