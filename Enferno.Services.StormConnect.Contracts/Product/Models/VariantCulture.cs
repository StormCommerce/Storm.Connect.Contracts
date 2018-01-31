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
        public string UniqueUrlName { get; set; }
        [DataMember]
        public bool IsUniqueUrlNameManuallyMaintained { get; set; }
    }
}