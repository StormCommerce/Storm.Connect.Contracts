using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.Contracts;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "Credit", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Credit : Entity
    {
        [DataMember(Order = 1)]
        public string CreditNo { get; set; }
        [DataMember(Order = 2)]
        public int ClientOrderRef { get; set; }
        [DataMember(Order = 3)]
        public string ErpOrderNo { get; set; }
        [DataMember(Order = 4)]
        public DateTime CreditDate { get; set; }
        [DataMember(Order = 5)]
        public Payment Payment { get; set; }
        [DataMember(Order = 6)]
        public string CurrencyCode { get; set; }
        [DataMember(Order = 7)]
        public List<CreditItem> Items { get; set; }
        [DataMember(Order = 8)]
        public Address Address { get; set; }
    }
}
