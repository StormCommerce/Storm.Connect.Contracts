using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "OrderStatus", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public enum OrderStatus
    {
        [EnumMember]
        Allocation = 1,
        [EnumMember]
        Confirmed = 2,
        [EnumMember]
        BackOrder = 3,
        [EnumMember]
        Delivered = 4,
        [EnumMember]
        Invoiced = 5,
        [EnumMember]
        Cancelled = 6,
        [EnumMember]
        CreditControl = 7,
        [EnumMember]
        PartlyDelivered = 8,
        [EnumMember]
        Acknowledged = 9,
        [EnumMember]
        ErpConfirmed = 10,
        [EnumMember]
        ReadyForPickup = 11,
        [EnumMember]
        PickedUp = 12,
        [EnumMember]
        NotPickedUp = 13,
        [EnumMember]
        OnHold = 14,
        [EnumMember]
        WaitingForCancel = 15,
        [EnumMember]
        WaitingForOnHoldRemoved = 16,
        [EnumMember]
        CancelError = 17,
        [EnumMember]
        AcknowledgementError = 18,
        [EnumMember]
        ReadyForReservation = 19,
        [EnumMember]
        Reserved = 20
    }
}
