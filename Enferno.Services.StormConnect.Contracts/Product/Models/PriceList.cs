using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Product.Models
{
    [DataContract(Name = "PriceList", Namespace = "Enferno.Services.StormConnect.Contracts.Product.Models")]
    public class PriceList
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string CurrencyCode { get; set; }
        [DataMember]
        public DateTime? StartDate { get; set; }
        [DataMember]
        public DateTime? EndDate { get; set; }
        [DataMember]
        public bool IsPrimary { get; set; }
        [DataMember]
        public bool IsPublic { get; set; }
        [DataMember]
        public string TypeCode { get; set; }
        [DataMember]
        public IEnumerable<Warehouse> Warehouses { get; set; }
        [DataMember]
        [Obsolete]
        public string DefaultPriceRuleCode { get; set; }
        [DataMember]
        public PriceRule DefaultPriceRule { get; set; }
        [DataMember]
        public decimal? DefaultPriceRuleValue { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public bool IsErpIntegrated { get; set; }
    }
}