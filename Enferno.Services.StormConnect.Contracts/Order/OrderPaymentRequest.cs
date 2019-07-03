using System;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Common;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "OrderPaymentRequest", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class OrderPaymentRequest : IOrderRequest, IExtensibleDataObject
    {
        [DataMember(Order = 1)]
        public Header Header { get; set; }
        [DataMember(Order = 2)]
        public string ClientOrderRef { get; set; }
        [DataMember(Order = 3)]
        public string ErpOrderNo { get; set; }
        [DataMember(Order = 4)]
        public Payment Payment { get; set; }
        public virtual ExtensionDataObject ExtensionData { get; set; }
    }
}
