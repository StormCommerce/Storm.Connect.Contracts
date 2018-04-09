using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [CollectionDataContract(Name = "CodeValues", ItemName = "Value", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public class CodeValues : List<CodeValue> { }
}
