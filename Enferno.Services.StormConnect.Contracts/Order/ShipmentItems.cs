using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "OrderItems", ItemName = "OrderItem", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class ShipmentItems : List<ShipmentItem> { }
}
