using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "PriceListItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class PriceListItem
    {
        [DataMember(Order = 1)]
        public string PriceListName { get; set; }
        [DataMember(Order = 2)]
        public int QtyBreak { get; set; }
        [DataMember(Order = 3)]
        public decimal UnitPrice { get; set; }
        [DataMember(Order = 4)]
        public bool IsStandardPriceList { get; set; }
        [DataMember(Order = 5)]
        public bool IsActive { get; set; }
    }
}