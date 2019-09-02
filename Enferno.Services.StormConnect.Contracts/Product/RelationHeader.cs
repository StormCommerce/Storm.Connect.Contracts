using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [DataContract(Name = "RelationHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public class RelationHeader : Header
    {
        public RelationHeader()
        {
            
        }

        [DataMember]
        public bool FullFile { get; set; }
    }
}
