#if !NETCORE
using System.ServiceModel;
using System.ServiceModel.Web;
#endif

namespace Enferno.Services.StormConnect.Contracts.Customer
{
#if !NETCORE
    [ServiceContract(Name = "CustomerService", Namespace = "Enferno.Services.StormConnect.Contracts.Customer")]
#endif
    public interface ICustomerService
    {
#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCustomer")]
#endif
        Response ImportCustomers(Request<CustomerHeader, Models.Customer> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCompany")]
#endif
        Response ImportCompanies(Request<CustomerHeader, Models.Company> request);
    }
}
