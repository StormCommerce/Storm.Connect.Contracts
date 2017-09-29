using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "Discounts", ItemName = "Discount", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Discounts : List<Discount> { }
}