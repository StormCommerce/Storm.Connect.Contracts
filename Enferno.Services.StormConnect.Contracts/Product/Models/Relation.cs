using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "Relation", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class Relation
    {
        [DataMember] public string PartNo { get; set; }
        [DataMember] public bool IsVariantUnique { get; set; }
        [DataMember] public string RelatedPartNo { get; set; }
        [DataMember] public bool IsRelatedVariantUnique { get; set; }
        [DataMember] public string RelationTypeCode { get; set; }
        [DataMember] public List<RelationCulture> Cultures { get; set; }

    }
}
