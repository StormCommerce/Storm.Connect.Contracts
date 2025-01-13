using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "VariantCulture", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class VariantCulture
    {
        [DataMember]
        public string CultureCode { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SubHeader { get; set; }
        [DataMember]
        public string SubDescription { get; set; }
        [DataMember]
        public string DescriptionHeader { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Synonyms { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Tags { get; set; }
        [DataMember]
        public string MetaTags { get; set; }
        [DataMember]
        public string MetaDescription { get; set; }
        [DataMember]
        public string UniqueUrlName { get; set; }
        [DataMember]
        public bool IsUniqueUrlNameManuallyMaintained { get; set; }
    }
}