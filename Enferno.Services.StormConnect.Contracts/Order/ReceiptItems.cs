using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "ReceiptItems", ItemName = "ReceiptItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class ReceiptItems : List<ReceiptItem> { }
}
