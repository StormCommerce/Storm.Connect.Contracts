using System.ServiceModel;
using System.ServiceModel.Web;
using Enferno.Services.StormConnect.Contracts.Job;
using Enferno.Services.StormConnect.Contracts.Supplier.Models;

namespace Enferno.Services.StormConnect.Contracts.Supplier
{
    [ServiceContract(Name = "SupplierService", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier")]
    public interface ISupplierService : ISupplierBaseService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportProduct")]
        Response ImportProduct(Request<SupplierProductHeader, SupplierProduct> request);
    }

    [ServiceContract]
    public interface ISupplierBaseService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/IsJobFinished/{jobId}")]
        bool IsJobFinished(string jobId);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/jobStatus/{jobIdRaw}")]
        JobDto JobStatus(string jobIdRaw);
    }
}