using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "WarehouseTransactionItems", ItemName = "WarehouseTransactionItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class WarehouseTransactionItems : List<WarehouseTransactionItem> { }
}
