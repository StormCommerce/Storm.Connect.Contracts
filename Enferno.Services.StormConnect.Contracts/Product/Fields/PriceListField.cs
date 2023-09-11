using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Fields
{
    [DataContract(Name = "PriceListField", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Fields")]
    public enum PriceListField
    {
        [EnumMember] Name = 0,
        [EnumMember] CurrencyCode = 1,
        [EnumMember] StartDate = 2,
        [EnumMember] EndDate = 3,
        [EnumMember] IsPublic = 4,
        [EnumMember] IsPrimary = 5,
        [EnumMember] TypeCode = 6,
        [EnumMember] Warehouses = 7,
        [EnumMember] DefaultPriceRule = 8,
        [EnumMember] Description = 9,
        [EnumMember] IsErpIntegrated = 10,
        [EnumMember] DoNotCreateApplicationPriceList = 11,
        [EnumMember] SalesArea = 12,
        [EnumMember] DefaultMinMarginPercent = 13,
        [EnumMember] LimitToRecPrice = 14,
        [EnumMember] ParentPriceListCode = 15,
        [EnumMember] DefaultSupplementalChargeFixed = 16,
        [EnumMember] DefaultSupplementalChargePercent = 17,
        [EnumMember] PriceRules = 18,
        [EnumMember] PriceRulesCleanup = 19,
        [EnumMember] PriceRulesLimitedUpdate = 20,
        [EnumMember] Population = 21,
        [EnumMember] PopulationCleanup = 22,
        [EnumMember] IsFavorite = 23
    }
}
