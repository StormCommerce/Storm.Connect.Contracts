using System.ServiceModel;
using System.ServiceModel.Web;

namespace Enferno.Services.StormConnect.Contracts.Customer
{
    [ServiceContract(Name = "CustomerService", Namespace = "Enferno.Services.StormConnect.Contracts.Customer")]
    public interface ICustomerService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCustomer")]
        Response ImportCustomers(Request<CustomerHeader, Models.Customer> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCompany")]
        Response ImportCompanies(Request<CustomerHeader, Models.Company> request);
    }
}