using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Supplier.Models
{
    [DataContract(Name = "SupplierProductInfo", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier.Models")]
    public class SupplierProductInfo
    {
        [DataMember(Order = 1)]
        public string Code { get; set; }
        [DataMember(Order = 2)]
        public string Value { get; set; }
    }
}