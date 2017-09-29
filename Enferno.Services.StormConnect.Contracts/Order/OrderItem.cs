using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "OrderItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class OrderItem
    {
        [DataMember(Order = 1)]
        public int LineNo { get; set; }
        [DataMember(Order = 2)]
        public int? ParentLineNo { get; set; }
        [DataMember(Order = 3)]
        public string Type { get; set; }
        [DataMember(Order = 4)]
        public string TypeGroup { get; set; }
        [DataMember(Order = 5)]
        public string PartNo { get; set; }
        [DataMember(Order = 6)]
        public string ErpPartNo { get; set; }
        [DataMember(Order = 7)]
        public int InternalProductId { get; set; }
        [DataMember(Order = 8)]
        public string Description { get; set; }
        [DataMember(Order = 9)]
        public int Quantity { get; set; }
        [DataMember(Order = 10)]
        public string UnitOfMeasure { get; set; }
        [DataMember(Order = 11)]
        public decimal UnitPrice { get; set; }
        [DataMember(Order = 12)]
        public decimal UnitPriceOriginal { get; set; }
        [DataMember(Order = 13)]
        public decimal Discount { get; set; }
        [DataMember(Order = 14)]
        public decimal UnitVat { get; set; }
        [DataMember(Order = 15)]
        public int? PriceListNo { get; set; }
        [DataMember(Order = 16)]
        public decimal VatRate { get; set; }
        [DataMember(Order = 17)]
        public string Comment { get; set; }
        [DataMember(Order = 18)]
        public CodeValues AdditionalInfo { get; set; }
        [DataMember(Order = 19)]
        public PriceListItems PriceLists { get; set; }
        [DataMember(Order = 20)]
        public Promotions Promotions { get; set; }
        [DataMember(Order = 21)]
        public string ManufacturerCode { get; set; }
    }
}
