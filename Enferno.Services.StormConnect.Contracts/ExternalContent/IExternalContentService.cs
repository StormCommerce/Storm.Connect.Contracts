#if !NETCORE
using System.ServiceModel;
using System.ServiceModel.Web;
#endif
using Enferno.Services.StormConnect.Contracts.ExternalContent.Models;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent
{
#if !NETCORE
    [ServiceContract(Name = "ExternalContentService", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent")]
#endif
    public interface IExternalContentService
    {
#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCategories")]
#endif
        Response ImportCategories(Request<MetadataHeader, ExternalContentCategory> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportParametricGroups")]
#endif
        Response ImportParametricGroups(Request<MetadataHeader, ExternalContentParametricGroup> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportParametrics")]
#endif
        Response ImportParametrics(Request<MetadataHeader, ExternalContentParametric> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCategoryParametrics")]
#endif
        Response ImportCategoryParametrics(Request<MetadataHeader, ExternalContentCategoryParametric> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportProducts")]
#endif
        Response ImportProducts(Request<MetadataHeader, ExternalContentProduct> request);
    }
}
