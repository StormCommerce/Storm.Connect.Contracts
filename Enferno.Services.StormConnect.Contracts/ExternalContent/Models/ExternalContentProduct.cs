using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Common;
using Enferno.Services.StormConnect.Contracts.Product.Models;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "ExternalContentProduct", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class ExternalContentProduct
    {
        public ExternalContentProduct()
        {
            ContentList = new List<ProductCulture>();
            Parametrics = new List<Parametric>();
            Images = new List<Image>();
        }
        [DataMember]
        public string ProductCode { get; set; }
        [DataMember]
        public string EanCode { get; set; }
        [DataMember]
        public string ManufacturerCode { get; set; }
        [DataMember]
        public string ManufacturerPartNo { get; set; }
        [DataMember]
        public Image MainImage { get; set; }
        [DataMember]
        public List<Image> Images { get; set; }
        [DataMember]
        public List<ProductCulture> ContentList { get; set; }
        [DataMember]
        public List<Parametric> Parametrics { get; set; }
    }
}