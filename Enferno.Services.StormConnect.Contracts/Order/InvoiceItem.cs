using System;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "InvoiceItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class InvoiceItem : Entity
    {
        [DataMember(Order = 1)]
        public decimal LineNo { get; set; }
        [DataMember(Order = 2)]
        public string PartNo { get; set; }
        [DataMember(Order = 3)]
        public string Description { get; set; }
        [DataMember(Order = 4)]
        public int Quantity { get; set; }
        [DataMember(Order = 6)]
        public decimal UnitPrice { get; set; }
        [DataMember(Order = 7)]
        [Obsolete("InvoiceItem.SalePrice field is deprecated. It will be removed in December 2017.")]
        public decimal? SalePrice { get; set; }
        [DataMember(Order = 8)]
        [Obsolete("InvoiceItem.LineAmount field is deprecated. It will be removed in December 2017.")]
        public decimal LineAmount { get; set; }
        [DataMember(Order = 9)]
        public decimal UnitVat { get; set; }
        [DataMember(Order = 10)]
        public string PriceList { get; set; }
        [DataMember(Order = 11)]
        public decimal VatRate { get; set; }
        [DataMember(Order = 12)]
        [Obsolete("InvoiceItem.Discount field is deprecated. It will be removed in December 2017.")]
        public decimal? Discount { get; set; }
    }
}
