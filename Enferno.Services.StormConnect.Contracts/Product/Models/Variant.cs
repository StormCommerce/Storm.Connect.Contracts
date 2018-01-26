using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Common;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "Variant", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class Variant
    {
        [DataMember]
        public string ManufacturerPartNo { get; set; }
        [DataMember]
        public int? SortOrderValue { get; set; }
        [DataMember]
        public int? StockDisplayBreakPoint { get; set; }
        [DataMember]
        public bool IsDangerousGoods { get; set; }
        [DataMember]
        public List<VariantCulture> Cultures { get; set; }
        [DataMember]
        public List<Sku> Skus { get; set; }
        [DataMember]
        public Image MainImage { get; set; }
        [DataMember]
        public List<Image> AdditionalImages { get; set; }
        [DataMember]
        public List<Flag> VariantFlags { get; set; }
        [DataMember]
        public List<ParametricValue> VariantParametrics { get; set; }
        [DataMember]
        public List<VariantDefinition> NonParametricVariantDefinitions { get; set; }
        [DataMember]
        public List<DeliveryMethod> DeliveryMethods { get; set; }
        [DataMember]
        public string UniqueUrlName { get; set; }
        [DataMember]
        public bool IsUniqueUrlNameManuallyMaintained { get; set; }
    }
}