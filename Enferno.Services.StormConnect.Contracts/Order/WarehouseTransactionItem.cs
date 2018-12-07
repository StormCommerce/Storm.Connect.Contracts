using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "WarehouseTransactionItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class WarehouseTransactionItem
    {
        [DataMember(Order = 1)]
        public decimal LineNumber { get; set; }
        [DataMember(Order = 2)]
        public string PartNo { get; set; }
        [DataMember(Order = 3)]
        public decimal Qty { get; set; }
        [DataMember(Order = 4)]
        public decimal Amount { get; set; }
        [DataMember(Order = 5)]
        public decimal? RemainingQty { get; set; }
        [DataMember(Order = 6)]
        public decimal? RemainingAmount { get; set; }
    }
}
