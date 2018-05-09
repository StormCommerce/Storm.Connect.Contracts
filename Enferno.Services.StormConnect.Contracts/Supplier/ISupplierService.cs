#if !NETCORE
using System.ServiceModel;
using System.ServiceModel.Web;
#endif
using Enferno.Services.StormConnect.Contracts.Job;
using Enferno.Services.StormConnect.Contracts.Supplier.Models;

namespace Enferno.Services.StormConnect.Contracts.Supplier
{
#if !NETCORE
    [ServiceContract(Name = "SupplierService", Namespace = "Enferno.Services.StormConnect.Contracts.Supplier")]
#endif
    public interface ISupplierService : ISupplierBaseService
    {
#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportProduct")]
#endif
        Response ImportProduct(Request<SupplierProductHeader, SupplierProduct> request);
    }

#if !NETCORE
    [ServiceContract]
#endif
    public interface ISupplierBaseService
    {
#if !NETCORE
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/IsJobFinished/{jobId}")]
#endif
        bool IsJobFinished(string jobId);

#if !NETCORE
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/jobStatus/{jobIdRaw}")]
#endif
        JobDto JobStatus(string jobIdRaw);
    }
}