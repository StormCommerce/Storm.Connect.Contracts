using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Product.Fields;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [DataContract(Name = "SkuPriceListHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public class SkuPriceListHeader : Header
    {
        public SkuPriceListHeader()
        {
            SkuPriceListFieldsThatAreSet = new List<SkuPriceListField>();
            IgnoreSkuPriceListFieldsWhenEmpty = new List<SkuPriceListField>();
        }
        [DataMember]
        public bool FullFile { get; set; }
        [DataMember]
        public IList<SkuPriceListField> IgnoreSkuPriceListFieldsWhenEmpty { get; set; }
        [DataMember]
        public IList<SkuPriceListField> SkuPriceListFieldsThatAreSet { get; set; }
    }
}
