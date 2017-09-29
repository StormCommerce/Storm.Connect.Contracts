using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [DataContract(Name = "PartNoImage", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public class PartNoImage
    {
        [DataMember(Order = 1)]
        public string PartNo { get; set; }
        [DataMember(Order = 2)]
        public string ExternalCode { get; set; }
        [DataMember(Order = 3)]
        public string FileType { get; set; }
        [DataMember(Order = 4)]
        public string Url { get; set; }
        [DataMember(Order = 5)]
        public bool? IsVariantUnique { get; set; }
    }
}
