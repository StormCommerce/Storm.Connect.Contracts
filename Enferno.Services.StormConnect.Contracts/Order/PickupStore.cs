using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "PickupStore", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class PickupStore
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public CodeValues AdditionalInfo { get; set; }
        [DataMember(Order = 4)]
        public bool IsDropPoint { get; set; }
        [DataMember(Order = 5)]
        public Address Address { get; set; }
    }

}