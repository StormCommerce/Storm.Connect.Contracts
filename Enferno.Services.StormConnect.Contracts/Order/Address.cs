using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Address", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Address : IExtensibleDataObject
    {
        [DataMember(Order = 1)]
        public string Type { get; set; }
        [DataMember(Order = 2)]
        public string Line1 { get; set; }
        [DataMember(Order = 3)]
        public string Line2 { get; set; }
        [DataMember(Order = 4)]
        public string Box { get; set; }
        [DataMember(Order = 5)]
        public string ZipCode { get; set; }
        [DataMember(Order = 6)]
        public string City { get; set; }
        [DataMember(Order = 7)]
        public string Region { get; set; }
        [DataMember(Order = 8)]
        public string Country { get; set; }
        [DataMember(Order = 9)]
        public string CareOf { get; set; }
        [DataMember(Order = 10)]
        public string ShippingPhoneNumber { get; set; }

        public virtual ExtensionDataObject ExtensionData { get; set; }
    }
}
