using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Common
{
    [DataContract(Name = "ImageCulture", Namespace = "Enferno.Services.StormConnect.Contracts.Common")]
    public class ImageCulture
    {
        [DataMember]
        public string CultureCode { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}