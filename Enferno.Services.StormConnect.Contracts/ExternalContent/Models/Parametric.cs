using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent.Models
{
    [DataContract(Name = "Parametric", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent.Models")]
    public class Parametric
    {
        [DataMember(Order = 1)]
        public string ParametricCode { get; set; }
        [DataMember(Order = 2)]
        public string ValueCode { get; set; }
        [DataMember(Order = 3)]
        public string ValueText { get; set; }
        [DataMember(Order = 4)]
        public bool? ValueBoolean { get; set; }
        [DataMember(Order = 5)]
        public decimal? ValueDecimal { get; set; }
        [DataMember(Order = 6)]
        public int? ValueInt { get; set; }
        [DataMember(Order = 7)]
        public DateTime? ValueDateTime { get; set; }
        [DataMember(Order = 8)]
        public IList<ParametricMultipleCodeValuePair> MultipleValues { get; set; }

        public Parametric()
        {
            MultipleValues = new List<ParametricMultipleCodeValuePair>();
        }
    }

    public class ParametricMultipleCodeValuePair
    {
        public string Code { get; set; }
        public string Value { get; set; }

        public static implicit operator ParametricMultipleCodeValuePair(string code)
        {
            return new ParametricMultipleCodeValuePair {Code = code, Value = code};
        }
    }
}