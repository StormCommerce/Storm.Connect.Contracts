using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "SkuType", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public enum SkuType
    {
        [EnumMember] ErpStandard = 1, // This is what you shuold use for standard, physical products. Known by the ERP.
        [EnumMember] ErpRefurbished = 2,
        [EnumMember] Freight = 3,
        [EnumMember] Insurance = 4,
        [EnumMember] Download = 7,
        [EnumMember] Structure = 8,
        [EnumMember] Invoice = 9,
        [EnumMember] Service = 11,
        [EnumMember] Standard = 14, // Called Standard by legacy. Used for extended assortment. Not known by the ERP (yet).
        [EnumMember] ErpExtended = 15, // Deprecated
        [EnumMember] ErpStandardNoStock = 16, // Deprecated
        [EnumMember] ErpPackage = 17, // Deprecated
        [EnumMember] Donations = 18, 
        [EnumMember] ErpTempOutOfStock = 19, // Deprecated
        [EnumMember] EnvironmentalFee = 20,
        [EnumMember] PackingFee = 21,
        [EnumMember] Configuration = 22, // Deprecated
        [EnumMember] ErpPackageWithCalc = 24, // Deprecated
        [EnumMember] DisplayOnly = 25, // Deprecated
        [EnumMember] ErpDownload = 26, // Deprecated
        [EnumMember] ErpDownloadNoStock = 27, // Deprecated
        [EnumMember] ErpDownloadTempNoStock = 28, // Deprecated
        [EnumMember] ErpStandard2 = 29, // Deprecated
        [EnumMember] Standard2 = 30, // Deprecated
        [EnumMember] ErpStandardNoStock2 = 31, // Deprecated
        [EnumMember] ErpTempOutOfStock2 = 32, // Deprecated
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
