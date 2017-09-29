using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "ProductCulture", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class ProductCulture
    {
        [DataMember(Order = 1)]
        public string CultureCode { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string SubHeader { get; set; }
        [DataMember(Order = 4)]
        public string SubDescription { get; set; }
        [DataMember(Order = 5)]
        public string DescriptionHeader { get; set; }
        [DataMember(Order = 6)]
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

    }
}