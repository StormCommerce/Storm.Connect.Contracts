using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "ParametricValue", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class ParametricValue
    {
        [DataMember]
        public string ParametricCode { get; set; }
        [DataMember]
        public bool? ValueBoolean { get; set; }
        [DataMember]
        public decimal? ValueDecimal { get; set; }
        [DataMember]
        public int? ValueInteger { get; set; }
        [DataMember]
        public DateTime? ValueDateTime { get; set; }
        [DataMember]
        public IEnumerable<ParametricValueCulture> Cultures { get; set; }
        [DataMember]
        public ParametricValueList ValueList { get; set; }
        [DataMember]
        public IEnumerable<ParametricValueList> MultipleValueList { get; set; }   
    }
}