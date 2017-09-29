using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts
{
    [DataContract(Name = "Status", Namespace = "Enferno.Services.StormConnect.Contracts")]
    public class ResponseStatus
    {
        [DataMember(Order = 1)]
        public string StatusCode { get; set; }
        [DataMember(Order = 2)]
        public string Description { get; set; }

        public ValidationSummary ValidationSummary { get; set; }
    }

    public class ValidationSummary
    {
        public ValidationSummary()
        {
            Messages = new List<string>();
        }

        public int NrOfItemsInTotal { get; set; }
        public int NrOfValidationFailures { get; set; }
        public IList<string> Messages { get; set; }
    }
}
