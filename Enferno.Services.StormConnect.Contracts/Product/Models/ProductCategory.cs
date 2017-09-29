using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "ProductCategory", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class ProductCategory
    {
        [DataMember]
        public int SortOrder { get; set; }
        [DataMember]
        public string Code { get; set; }
    }
}