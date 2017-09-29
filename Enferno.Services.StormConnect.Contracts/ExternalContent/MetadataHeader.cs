using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Product.Fields;
using Enferno.Services.StormConnect.Contracts.ExternalContent.Fields;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent
{
    [DataContract(Name = "MetadataHeader", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent")]
    public class MetadataHeader : Header
    {
        public MetadataHeader()
        {
            CategoryFieldsThatAreSet = new List<ExternalContentCategoryField>();
            ParametricFieldsThatAreSet = new List<ExternalContentParametricField>();
            ContentFieldsThatAreSet = new List<ProductCultureField>();
        }

        [DataMember]
        public bool FullFile { get; set; }
        [DataMember]
        public string ExternalContentName { get; set; }
        [DataMember]
        public IList<ExternalContentCategoryField> CategoryFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<ExternalContentParametricField> ParametricFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<ProductCultureField> ContentFieldsThatAreSet { get; set; }
    }
}