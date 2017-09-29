using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "Payments", ItemName = "Payment", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class Payments : List<Payment> { }
}