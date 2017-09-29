using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "ExternalContentCategoryParametric", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class ExternalContentCategoryParametric
    {
        [DataMember]
        public string CategoryCode { get; set; }
        [DataMember]
        public string ParametricCode { get; set; }
        [DataMember]
        public string ParametricGroupCode { get; set; }
    }
}