using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "Relation", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class Relation
    {
        [DataMember]
        public string PartNo { get; set; }
        [DataMember]
        public bool IsVariantUnique { get; set; }
        [DataMember]
        public string RelatedPartNo { get; set; }
        [DataMember]
        public bool IsRelatedVariantUnique { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public string RelationTypeCode { get; set; }
        [DataMember]
        public string DefaultName { get; set; }
        [DataMember]
        public string DefaultSubHeader { get; set; }
        [DataMember]
        public string DefaultSubDescription { get; set; }
        [DataMember]
        public string DefaultDescriptionHeader { get; set; }
        [DataMember]
        public string DefaultDescription { get; set; }
        [DataMember]
        public List<RelationCulture> Cultures { get; set; }
        [DataMember] 
        public int? SortOrder { get; set; }

    }
}
