using System.Collections.Generic;
using System.Runtime.Serialization;
using Enferno.Services.StormConnect.Contracts.Customer.Fields;

namespace Enferno.Services.StormConnect.Contracts.Customer
{
    [DataContract(Name = "CustomerHeader", Namespace = "Enferno.Services.StormConnect.Contracts.Customer")]
    public class CustomerHeader : Header
    {
        public CustomerHeader()
        {
            AccountFieldsThatAreSet = new List<AccountField>();
            CompanyFieldsThatAreSet = new List<CompanyField>();
            CustomerFieldsThatAreSet = new List<CustomerField>();
        }
        [DataMember]
        public IList<AccountField> AccountFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<CompanyField> CompanyFieldsThatAreSet { get; set; }
        [DataMember]
        public IList<CustomerField> CustomerFieldsThatAreSet { get; set; }
    }
}