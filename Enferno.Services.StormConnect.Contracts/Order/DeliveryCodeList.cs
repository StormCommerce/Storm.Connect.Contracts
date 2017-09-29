using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "DeliveryCodeList", ItemName = "DeliveryCode", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class DeliveryCodeList : List<string> { }
}