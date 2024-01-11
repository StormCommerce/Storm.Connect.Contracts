using System.Runtime.Serialization;

namespace Enferno.Services.StormConnect.Contracts.Customer.Models
{
    public interface ICompanyIdentifier
    {
        int? Id { get; set; }
        string Code { get; set; }
        string OrganizationNo { get; set; }
        string Name { get; set; }
        bool? IsPrimary { get; set; }
    }

    [DataContract(Name = "CompanyIdentifier", Namespace = "Enferno.Services.StormConnect.Contracts.Customer.Models")]
    public class CompanyIdentifier : ICompanyIdentifier
    {
        [DataMember]
        public int? Id { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string OrganizationNo { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public bool? IsPrimary { get; set; }
    }
}
