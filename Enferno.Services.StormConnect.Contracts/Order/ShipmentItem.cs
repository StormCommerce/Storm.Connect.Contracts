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
        /// <summary>
        /// Deprecated - Use PurchaseCost
        /// </summary>
        [DataMember(Order = 5)]
        public decimal? Price { get; set; }

        [DataMember(Order = 6)] 
        public decimal? PurchaseCost { get; set; }
        [DataMember(Order = 7)] 
        public decimal? UnitCost { get; set; }
        [DataMember(Order = 8)]
        public string PackageNo { get; set; }
    }
}
