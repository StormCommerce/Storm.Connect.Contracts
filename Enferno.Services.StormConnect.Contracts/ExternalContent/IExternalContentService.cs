using System.ServiceModel;
using System.ServiceModel.Web;
using Enferno.Services.StormConnect.Contracts.ExternalContent.Models;

namespace Enferno.Services.StormConnect.Contracts.ExternalContent
{
    [ServiceContract(Name = "ExternalContentService", Namespace = "Enferno.Services.StormConnect.Contracts.ExternalContent")]
    public interface IExternalContentService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCategories")]
        Response ImportCategories(Request<MetadataHeader, ExternalContentCategory> request);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportParametricGroups")]
        Response ImportParametricGroups(Request<MetadataHeader, ExternalContentParametricGroup> request);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportParametrics")]
        Response ImportParametrics(Request<MetadataHeader, ExternalContentParametric> request);
        
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCategoryParametrics")]
        Response ImportCategoryParametrics(Request<MetadataHeader, ExternalContentCategoryParametric> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "ImportProducts")]
        Response ImportProducts(Request<MetadataHeader, ExternalContentProduct> request);
    }
}
