using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    [DataContract(Name = "Address", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class Address
    {
        [DataMember]
        public string CareOf { get; set; }
        [DataMember]
        public string AddressLine1 { get; set; }
        [DataMember]
        public string AddressLine2 { get; set; }
        [DataMember]
        public string ZipCode { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Region { get; set; }
        [DataMember]
        public string CountryCode { get; set; }
        [DataMember]
        public string Gln { get; set; }
    }
}
