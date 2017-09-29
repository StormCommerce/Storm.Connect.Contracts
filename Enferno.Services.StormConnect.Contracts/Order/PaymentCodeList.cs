using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "PaymentCodeList", ItemName = "PaymentCode", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class PaymentCodeList : List<string> { }
}