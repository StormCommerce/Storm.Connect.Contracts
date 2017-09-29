using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "Promotions", ItemName = "Promotion", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Promotions : List<Promotion> { }
}