using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Product.Fields;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [DataContract(Name = "CompetitorSkuHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public class CompetitorSkuHeader : Header
    {
        public CompetitorSkuHeader()
        {
            CompetitorSkuFieldsThatAreSet = new List<CompetitorSkuField>();
        }

        [DataMember]
        public bool FullFile { get; set; }
        [DataMember]
        public IList<CompetitorSkuField> CompetitorSkuFieldsThatAreSet { get; set; }
    }
}
