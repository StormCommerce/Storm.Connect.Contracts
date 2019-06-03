using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [DataContract(Name = "ShipmentPackage", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class ShipmentPackage
    {
        [DataMember(Order = 1)]
        public string PackageNo { get; set; }
        [DataMember(Order = 2)]
        public string Barcode { get; set; }
        [DataMember(Order = 3)]
        public string Comment { get; set; }
    }
}
