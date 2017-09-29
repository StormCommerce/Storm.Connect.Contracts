using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "WarehouseLocation", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class WarehouseLocation
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool? IsIncludedInStockCalculation { get; set; }
        [DataMember]
        public int? LeadTimeDayCount { get; set; }
    }
}