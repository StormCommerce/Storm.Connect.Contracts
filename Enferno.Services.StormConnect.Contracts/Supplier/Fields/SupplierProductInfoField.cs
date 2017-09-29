using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Supplier.Fields
{
    [DataContract(Name = "SupplierProductInfoField", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier.Fields")]
    public enum SupplierProductInfoField
    {
        [EnumMember]
        Value,
    }
}