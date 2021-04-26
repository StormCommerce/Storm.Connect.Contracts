using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SkuType", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum SkuType
    {
        [EnumMember] ErpStandard = 1,
        [EnumMember] ErpRefurbished = 2,
        [EnumMember] Freight = 3,
        [EnumMember] Insurance = 4,
        [EnumMember] Structure = 8,
        [EnumMember] Invoice = 9,
        [EnumMember] Service = 11,
        [EnumMember] Standard = 14,
        [EnumMember] ErpExtended = 15,
        [EnumMember] ErpStandardNoStock = 16,
        [EnumMember] ErpPackage = 17,
        [EnumMember] ErpTempOutOfStock = 19,
        [EnumMember] EnvironmentalFee = 20,
        [EnumMember] PackingFee = 21,
        [EnumMember] ErpPackageWithCalc = 24,
        [EnumMember] DisplayOnly = 25,
        [EnumMember] ErpStandard2 = 29,
        [EnumMember] Standard2 = 30,
        [EnumMember] License = 33,
        [EnumMember] PspGiftCard = 41,
        [EnumMember] Compensation = 44
    }
}
