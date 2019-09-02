using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "RelationCulture", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class RelationCulture
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
    }
}