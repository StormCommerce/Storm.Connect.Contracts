using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    /// <summary>Fee class</summary>
    [DataContract(Name = "Fee", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Fee 
    {
        /// <summary></summary>
        [DataMember(Order = 1)]
        public string Type { get; set; }
        /// <summary></summary>
        [DataMember(Order = 2)]
        public string Description { get; set; }
        /// <summary></summary>
        [DataMember(Order = 3)]
        public decimal Amount { get; set; }
        /// <summary></summary>
        [DataMember(Order = 4)]
        public decimal VatRate { get; set; }
    }
}
