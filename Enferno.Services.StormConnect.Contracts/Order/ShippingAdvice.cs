using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "ShippingAdvice", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public partial class ShippingAdvice
    {
        [DataMember(Order = 1)]
        public string DeliveryMethodCode { get; set; }
        [DataMember(Order = 2)]
        // ReSharper disable once InconsistentNaming
        public bool DoSMSNotify { get; set; }
        [DataMember(Order = 3)]
        public PickupStore PickupStore { get; set; }
        [DataMember(Order = 4)]
        public bool IsFeeChargedOnce { get; set; }
        [DataMember(Order = 5)]
        public bool IsComplete { get; set; }
        [DataMember(Order = 6)]
        public string ShipAdvisorOrderCode { get; set; }
        [DataMember(Order = 7)]
        public string TmsReference { get; set; }
    }
}