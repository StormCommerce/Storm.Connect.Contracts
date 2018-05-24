#if !NETCORE
using System.ServiceModel;
using System.ServiceModel.Web;
#endif

namespace Enferno.Services.StormConnect.Contracts.Order
{
#if !NETCORE
    [ServiceContract(Name = "OrderNotificationService", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
#endif
    public interface IOrderNotificationService
    {
#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "CreateOrder")]
#endif
        OrderResponse CreateOrder(OrderRequest request);
    }
}
