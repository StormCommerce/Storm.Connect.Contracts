using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "ExternalContentCategory", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class ExternalContentCategory
    {
        public ExternalContentCategory()
        {
            Translations = new List<ExternalContentCategoryCulture>();
        }
        [DataMember]
        public string CategoryCode { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public string CategoryFullName { get; set; }
        [DataMember]
        public string UnspcCode { get; set; }
        [DataMember]
        public string ParentCategoryCode { get; set; }
        [DataMember]
        public bool HasRequirements { get; set; }
        [DataMember]
        public bool IsHidden { get; set; }

        public IList<ExternalContentCategoryCulture> Translations { get; set; }
    }
}