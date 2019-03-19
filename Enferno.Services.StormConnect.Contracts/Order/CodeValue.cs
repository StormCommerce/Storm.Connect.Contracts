using System.Runtime.Serialization;
using System;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "CodeValue", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class CodeValue : Entity
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        [Obsolete("Use Code2 to get real Code. This one has wrong values. Info.Name gets wrongly mapped here.")]
        public string Code { get; set; }
        [DataMember(Order = 3)]
        public string Value { get; set; }
        [DataMember(Order = 4)]
        public string Code2 { get; set; }
    }
}
