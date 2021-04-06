using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Invoice", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Invoice : Entity
    {
        [DataMember(Order = 1)]
        public string InvoiceNo { get; set; }
        [DataMember(Order = 2)]
        public int ClientOrderRef { get; set; }
        [DataMember(Order = 3)]
        public string ErpOrderNo { get; set; }
        [DataMember(Order = 4)]
        public DateTime DeliveryDate { get; set; }
        [DataMember(Order = 5)]
        public DateTime InvoiceDate { get; set; }
        [DataMember(Order = 6)]
        public DateTime InvoiceDueDate { get; set; }
        [DataMember(Order = 7)]
        public Payment Payment { get; set; }
        [DataMember(Order = 8)]
        public string CurrencyCode { get; set; }
        [DataMember(Order = 9)]
        [Obsolete("Invoice.TotalAmount field is deprecated. It will be removed in December 2017. Use Invoice.Payment.Amount instead.")]
        public decimal TotalAmount { get; set; }
        [DataMember(Order = 10)]
        public decimal InvoiceRoundOff { get; set; }
        [DataMember(Order = 11)]
        public decimal Vat { get; set; }
        [DataMember(Order = 12)]
        [Obsolete("Invoice.VatRoundOff field is deprecated. It will be removed in December 2017.")]
        public decimal? VatRoundOff { get; set; }
        [DataMember(Order = 13)]
        public List<InvoiceItem> Items { get; set; }
        [DataMember(Order = 14)]
        public string Name { get; set; }
        [DataMember(Order = 15)]
        public string AddressLine1 { get; set; }
        [DataMember(Order = 16)]
        public string AddressLine2 { get; set; }
        [DataMember(Order = 17)]
        public string ZipCode { get; set; }
        [DataMember(Order = 18)]
        public string City { get; set; }
        [DataMember(Order = 19)]
        public Guid? ApplicationKey { get; set; }
        [DataMember(Order = 20)]
        public bool? IsLastInvoiceForOrder { get; set; }
        [DataMember(Order = 21)]
        public string CreditedInvoiceNo { get; set; }
        [DataMember(Order = 22)]
        public string Comment { get; set; }
        [DataMember(Order = 23)]
        public string Attention { get; set; }
        [DataMember(Order = 24)]
        public string CareOf { get; set; }
        [DataMember(Order = 25)]
        public string Region { get; set; }
        [DataMember(Order = 26)]
        public string Country { get; set; }
        [DataMember(Order = 27)]
        public string GroupCode { get; set; }
        [DataMember(Order = 28)]
        public string Gln { get; set; }
        [DataMember(Order = 29)]
        public string PaymentMethodCode { get; set; }
        [DataMember(Order = 30)]
        public string PaymentMethodName { get; set; }
        [DataMember(Order = 31)]
        public bool SuppressPspCall { get; set; }
        [DataMember(Order = 32)]
        public string CultureCode { get; set; }
    }
}
