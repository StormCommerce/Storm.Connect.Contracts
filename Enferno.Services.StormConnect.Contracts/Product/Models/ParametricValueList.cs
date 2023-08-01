﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "ParametricValueList", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class ParametricValueList
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Value { get; set; }
        [DataMember]
        public IEnumerable<ParametricValueListCulture> Cultures { get; set; }
        [DataMember]
        public string Description { get; set; }
    }
}