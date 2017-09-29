using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "DeliveryMethod", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class DeliveryMethod
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public decimal? PackagePercentage{ get; set; }
        [DataMember]
        public bool? IsActive { get; set; }
    }
}