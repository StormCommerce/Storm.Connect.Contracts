using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "DeliveryNote", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class DeliveryNote
    {
        [DataMember(Order = 1)]
        public string OrderNo { get; set; }
        [DataMember(Order = 2)]
        public string NoteNo { get; set; }
        [DataMember(Order = 3)]
        public string BuyerCompanyCode { get; set; }
        [DataMember(Order = 4)]
        public string BuyerCustomerCode { get; set; }     
        [DataMember(Order = 5)]
        public Address DeliveryAddress { get; set; }
        [DataMember(Order = 6)]
        public DateTime DeliveryDate { get; set; }
        [DataMember(Order = 7)]
        [Obsolete("DeliveryNote.IsPrinted field is deprecated. It will be removed in December 2017.")]
        public bool? IsPrinted { get; set; }
        [DataMember(Order = 8)]
        public string DeliveryName { get; set; }
        [DataMember(Order = 9)]
        public string DeliveryAttention { get; set; }
        [DataMember(Order = 10)]
        public string DeliveryMode { get; set; }
        [DataMember(Order = 11)]
        public string NoteText { get; set; }
        [DataMember(Order = 12)]
        public string DivisionCode { get; set; }
        [DataMember(Order = 13)]
        public int StatusId { get; set; }
        [DataMember(Order = 14)]
        public  List<DeliveryNotePackage> DeliveryNotePackages { get; set; }
        [DataMember(Order = 15)]
        public List<DeliveryNoteItem> DeliveryNoteItems { get; set; }   
    }

    [DataContract(Name = "DeliveryNoteItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class DeliveryNoteItem
    {
        [DataMember(Order = 1)]
        [Obsolete("DeliveryNoteItem.Id field is deprecated. It will be removed in December 2017.")]
        public int? Id { get; set; }
        [DataMember(Order = 2)]
        public decimal RowNumber { get; set; }
        [DataMember(Order = 3)]
        public string ItemNo { get; set; }
        [DataMember(Order = 4)]
        public string Description { get; set; }
        [DataMember(Order = 5)]
        public decimal Qty { get; set; }
        [DataMember(Order = 8)]
        public string Comment { get; set; }
    }

    [DataContract(Name = "DeliveryNotePackage", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class DeliveryNotePackage
    {
        [DataMember(Order = 1)]
        [Obsolete("DeliveryNotePackage.Id field is deprecated. It will be removed in December 2017.")]
        public int? Id { get; set; }
        [DataMember(Order = 2)]
        public string ParcelNumber { get; set; }
        [DataMember(Order = 3)]
        public int StatusId { get; set; }
    }
}
