using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Product.Fields;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [DataContract(Name = "SkuOnhandHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public class SkuOnhandHeader : Header
    {
        public SkuOnhandHeader()
        {
            SkuOnhandFieldsThatAreSet = new List<SkuOnhandField>();
        }

        [DataMember]
        public bool FullFile { get; set; }
        [DataMember]
        public IList<SkuOnhandField> SkuOnhandFieldsThatAreSet { get; set; }
    }
}
