using System.ServiceModel;
using System.ServiceModel.Web;
using Enferno.Services.StormConnect.Contracts.Product.Models;

namespace Enferno.Services.StormConnect.Contracts.Product
{
    [ServiceContract(Name = "ProductService", Namespace = "Enferno.Services.StormConnect.Contracts.Product")]
    public interface IProductService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "ImportImage")]
        Response ImportImages(Request<ProductHeader, PartNoImage> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "ImportProduct")]
        Response ImportProducts(Request<ProductHeader, Models.Product> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "ImportSkuPriceList")]
        Response ImportSkuPriceLists(Request<SkuPriceListHeader, Models.SkuPriceList> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "ImportPriceList")]
        Response ImportPriceLists(Request<PriceListHeader, Models.PriceList> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "ImportOnhand")]
        Response ImportOnhands(Request<SkuOnhandHeader, Models.SkuOnhand> request);

        [OperationContract]
        [WebInvoke(UriTemplate = "ImportCompetitorSku")]
        Response ImportCompetitorSkus(Request<CompetitorSkuHeader, Models.CompetitorSku> request);
    }
}