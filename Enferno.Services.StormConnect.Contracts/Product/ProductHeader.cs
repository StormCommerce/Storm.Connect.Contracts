using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Product.Fields;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [DataContract(Name = "ProductHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public class ProductHeader : Header
    {
        public ProductHeader()
        {
            ProductFieldsThatAreSet = new List<ProductField>();
            ProductCultureFieldsThatAreSet = new List<ProductCultureField>();
            SkuFieldsThatAreSet = new List<SkuField>();
            SkuCultureFieldsThatAreSet = new List<SkuCultureField>();
            SkuPriceListFieldsThatAreSet = new List<SkuPriceListField>();
            IgnoreSkuPriceListFieldsWhenEmpty = new List<SkuPriceListField>();
            SkuStructureItemFieldsThatAreSet = new List<SkuStructureItemField>();
            VariantFieldsThatAreSet = new List<VariantField>();
            VariantCultureFieldsThatAreSet = new List<VariantCultureField>();
        }
        [DataMember]
        public bool FullFile { get; set; }
        [DataMember]
        public IList<ProductField> ProductFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<SkuField> SkuFieldsThatAreSet{ get; set; }
        [DataMember]
        public IList<SkuCultureField> SkuCultureFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<SkuPriceListField> SkuPriceListFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<SkuPriceListField> IgnoreSkuPriceListFieldsWhenEmpty { get; set; }
        [DataMember]
        public IList<SkuStructureItemField> SkuStructureItemFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<ProductCultureField> ProductCultureFieldsThatAreSet{ get; set; }
        [DataMember]
        public IList<VariantField> VariantFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<VariantCultureField> VariantCultureFieldsThatAreSet { get; set; }
    }
}
