using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SkuCulture", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class SkuCulture
    {
        [DataMember]
        public string CultureCode { get; set; }
        [DataMember]
        public string ErpName { get; set; }
        [DataMember]
        public string Comment { get; set; }

    }
}
