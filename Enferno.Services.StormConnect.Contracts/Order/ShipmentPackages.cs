using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "ShipmentPackages", ItemName = "ShipmentPackage", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class ShipmentPackages : List<ShipmentPackage> { }
}
