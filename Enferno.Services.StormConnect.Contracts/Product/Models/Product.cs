using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Common;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "Product", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class Product
    {
        [DataMember]
        public string ManufacturerCode { get; set; }
        [DataMember]
        public string ManufacturerName { get; set; }
        [DataMember]
        public string Alias { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public List<Variant> Variants { get; set; }
        [DataMember]
        public List<ProductCulture> Cultures { get; set; }
        [DataMember]
        public List<ProductCategory> Categories { get; set; }
        [DataMember]
        public Image MainImage { get; set; }
        [DataMember]
        public List<Image> AdditionalImages { get; set; }
        [DataMember]
        public ProductFamily Family { get; set; }
        [DataMember]
        public List<Flag> ProductFlags { get; set; }
        [DataMember]
        public List<ParametricValue> ProductParametrics { get; set; }
        [DataMember]
        public VariantDefinitionGroup VariantDefinitionGroup { get; set; }
        [DataMember]
        public string AssortmentCode { get; set; }
    }
}
