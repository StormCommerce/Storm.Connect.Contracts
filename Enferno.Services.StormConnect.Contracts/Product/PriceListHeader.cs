using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Product.Fields;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [DataContract(Name = "PriceListHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public class PriceListHeader : Header
    {
        public PriceListHeader()
        {
            PriceListFieldsThatAreSet = new List<PriceListField>();
            WarehouseFieldsThatAreSet = new List<WarehouseField>();
            WarehouseLocationFieldsThatAreSet = new List<WarehouseLocationField>();
        }
        [DataMember]
        public IList<PriceListField> PriceListFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<WarehouseField> WarehouseFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<WarehouseLocationField> WarehouseLocationFieldsThatAreSet { get; set; }
    }
}
