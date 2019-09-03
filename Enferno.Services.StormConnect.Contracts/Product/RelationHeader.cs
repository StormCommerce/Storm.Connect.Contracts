using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Product.Fields;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [DataContract(Name = "RelationHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public class RelationHeader : Header
    {
        public RelationHeader()
        {
            RelationFieldsThatAreSet = new List<RelationField>();
            RelationCultureFieldsThatAreSet = new List<RelationCultureField>();
        }

        [DataMember]
        public bool FullFile { get; set; }
        [DataMember]
        public IList<RelationField> RelationFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<RelationCultureField> RelationCultureFieldsThatAreSet { get; set; }
    }
}
