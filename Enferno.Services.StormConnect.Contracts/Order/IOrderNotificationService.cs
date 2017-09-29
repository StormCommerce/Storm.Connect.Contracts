using System.ServiceModel;
using System.ServiceModel.Web;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    [ServiceContract(Name = "OrderNotificationService", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
    public interface IOrderNotificationService
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "CreateOrder")]
        OrderResponse CreateOrder(OrderRequest request);
    }
}
