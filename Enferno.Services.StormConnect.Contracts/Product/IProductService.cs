#if !NETCORE
using System.ServiceModel;
using System.ServiceModel.Web;
#endif
using Enferno.Services.StormConnect.Contracts.Product.Models;

namespace Enferno.Services.StormConnect.Contracts.Product
{
#if !NETCORE
    [ServiceContract(Name = "ProductService", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
#endif
    public interface IProductService
    {
#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportImage")]
#endif
        Response ImportImages(Request<ProductHeader, PartNoImage> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportProduct")]
#endif
        Response ImportProducts(Request<ProductHeader, Models.Product> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportSkuPriceList")]
#endif
        Response ImportSkuPriceLists(Request<SkuPriceListHeader, Models.SkuPriceList> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportPriceList")]
#endif
        Response ImportPriceLists(Request<PriceListHeader, Models.PriceList> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportOnhand")]
#endif
        Response ImportOnhands(Request<SkuOnhandHeader, Models.SkuOnhand> request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCompetitorSku")]
#endif
        Response ImportCompetitorSkus(Request<CompetitorSkuHeader, Models.CompetitorSku> request);
    }
}
