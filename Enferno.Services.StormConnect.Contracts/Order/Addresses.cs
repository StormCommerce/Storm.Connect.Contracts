using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "Addresses", ItemName = "Address", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Addresses : List<Address> { }
}