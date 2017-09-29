using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "Fees", ItemName = "Fee", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Fees : List<Fee> { }
}