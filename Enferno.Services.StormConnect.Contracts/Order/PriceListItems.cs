using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "PriceListItems", ItemName = "Pricelist", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public partial class PriceListItems : List<PriceListItem> { }
}