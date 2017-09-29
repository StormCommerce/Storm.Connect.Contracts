using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "CodeValue", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class CodeValue
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Code { get; set; }
        [DataMember(Order = 3)]
        public string Value { get; set; }
    }
}