
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "ProductCategory", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class ProductFamily
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}
