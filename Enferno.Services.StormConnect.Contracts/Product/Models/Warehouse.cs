using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "Warehouse", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class Warehouse
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public WarehouseType Type { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int? LeadTimeDayCount { get; set; }
        [DataMember]
        public IEnumerable<WarehouseLocation> Locations { get; set; }
    }
}