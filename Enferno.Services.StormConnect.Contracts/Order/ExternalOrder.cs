using System;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "ExternalOrder", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class ExternalOrder
    {
        [DataMember(Order = 1)]
        public Header Header { get; set; }
        [DataMember(Order = 2)]
        public DateTime OrderDate { get; set; }
        [DataMember(Order = 3)]
        public ClientCustomer SellTo { get; set; }
        [DataMember(Order = 4)]
        public ClientCustomer BillTo { get; set; }
        [DataMember(Order = 5)]
        public ClientCustomer ShipTo { get; set; }
        [DataMember(Order = 6)]
        public string SalesDivisionCode { get; set; }
        [DataMember(Order = 7)]
        public string SalesContactCode { get; set; }
        [DataMember(Order = 8)]
        public string DeliveryDivisionCode { get; set; }
        [DataMember(Order = 9)]
        public string ErpOrderNo { get; set; }
        [DataMember(Order = 10)]
        public string CustomerOrderRef { get; set; }
        [DataMember(Order = 11)]
        public string CustomerOrderComment { get; set; }
        [DataMember(Order = 12)]
        public Invoices Invoices { get; set; }
        [DataMember(Order = 13)]
        public string CurrencyCode { get; set; }
        [DataMember(Order = 14)]
        public ShippingAdvice ShippingAdvice { get; set; }
        [DataMember(Order = 15)]
        public OrderItems Items { get; set; }
        [DataMember(Order = 16)]
        public CodeValues AdditionalInfo { get; set; }
        [DataMember(Order = 17)]
        public string Source { get; set; }
        public virtual ExtensionDataObject ExtensionData { get; set; }
    }
}
