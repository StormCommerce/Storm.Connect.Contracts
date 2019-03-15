using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "ReceiptItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class ReceiptItem
    {
        [DataMember(Order = 1)]
        public int LineNo { get; set; }
        [DataMember(Order = 2)]
        public int? ParentLineNo { get; set; }
        [DataMember(Order = 3)]
        public string PartNo { get; set; }
        [DataMember(Order = 4)]
        public string ErpPartNo { get; set; }
        [DataMember(Order = 5)]
        public string Description { get; set; }
        [DataMember(Order = 6)]
        public decimal Quantity { get; set; }
        [DataMember(Order = 7)]
        public decimal UnitPrice { get; set; }
        [DataMember(Order = 8)]
        public decimal UnitPriceOriginal { get; set; }
        [DataMember(Order = 9)]
        public decimal Discount { get; set; }
        [DataMember(Order = 10)]
        public decimal UnitVat { get; set; }
        [DataMember(Order = 11)]
        public decimal VatRate { get; set; }
        [DataMember(Order = 12)]
        public string Comment { get; set; }
        [DataMember(Order = 13)]
        public CodeValues AdditionalInfo { get; set; }
    }
}
