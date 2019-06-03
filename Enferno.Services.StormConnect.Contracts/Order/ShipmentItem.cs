using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "ShipmentItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class ShipmentItem
    {
        [DataMember(Order = 1)]
        public int LineNo { get; set; }
        [DataMember(Order = 2)]
        public string PartNo { get; set; }
        [DataMember(Order = 3)]
        public string Name { get; set; }
        [DataMember(Order = 4)]
        public int Quantity { get; set; }
        [DataMember(Order = 5)]
        public decimal? Price { get; set; }
        [DataMember(Order = 6)]
        public string PackageNo { get; set; }
    }
}
