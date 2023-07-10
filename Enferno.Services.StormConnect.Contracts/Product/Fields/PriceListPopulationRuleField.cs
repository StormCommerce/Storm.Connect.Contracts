using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "PriceListPopulationRuleField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum PriceListPopulationRuleField
    {
        [EnumMember] ManufacturerCode = 0,
        [EnumMember] CategoryCode = 1,
        [EnumMember] Flags = 2,
        [EnumMember] SupplierRequired = 3
    }
}
