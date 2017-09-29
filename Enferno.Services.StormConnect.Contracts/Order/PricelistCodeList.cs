using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "PricelistCodeList", ItemName = "PricelistCode", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class PricelistCodeList : List<string> { }
}