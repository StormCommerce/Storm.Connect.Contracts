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
        [EnumMember] Download = 7,
        [EnumMember] Structure = 8,
        [EnumMember] Invoice = 9,
        [EnumMember] Service = 11,
        [EnumMember] Standard = 14,
        [EnumMember] ErpExtended = 15,
        [EnumMember] ErpStandardNoStock = 16,
        [EnumMember] ErpPackage = 17,
        [EnumMember] Donations = 18,
        [EnumMember] ErpTempOutOfStock = 19,
        [EnumMember] EnvironmentalFee = 20,
        [EnumMember] PackingFee = 21,
        [EnumMember] Configuration = 22,
        [EnumMember] ErpPackageWithCalc = 24,
        [EnumMember] DisplayOnly = 25,
        [EnumMember] ErpDownload = 26,
        [EnumMember] ErpDownloadNoStock = 27,
        [EnumMember] ErpDownloadTempNoStock = 28,
        [EnumMember] ErpStandard2 = 29,
        [EnumMember] Standard2 = 30,
        [EnumMember] ErpStandardNoStock2 = 31,
        [EnumMember] ErpTempOutOfStock2 = 32,
        [EnumMember] License = 33,
        [EnumMember] CentRounding = 34,
        [EnumMember] SalesTax = 35,
        [EnumMember] FreightStructure = 36,
        [EnumMember] ManagedStructure = 37,
        [EnumMember] ManagedErpPackage = 38,
        [EnumMember] ManagedErpPackageWithCalc = 39,
        [EnumMember] Virtual = 40,
        [EnumMember] PspGiftCard = 41,
        [EnumMember] PayLater = 42,
        [EnumMember] GiftCardPaymentPlaceHolder = 43,
        [EnumMember] Compensation = 44
    }
}
