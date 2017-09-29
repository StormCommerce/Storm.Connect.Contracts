using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SkuStructureItem", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class SkuStructureItem
    {
        [DataMember]
        public string StructurePartNo { get; set; }
        [DataMember]
        public string PartNo { get; set; }
        [DataMember]
        public decimal Quantity { get; set; }
        [DataMember]
        public int? SortOrder { get; set; }
        [DataMember]
        public SkuStructureItemPriceList StandardStructureItemPrice { get; set; }
        [DataMember]
        public IEnumerable<Info> AdditionalInfo { get; set; }
    }
}
