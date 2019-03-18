#if !NETCORE
using System.ServiceModel;
using System.ServiceModel.Web;
#endif

namespace Enferno.Services.StormConnect.Contracts.Order
{
#if !NETCORE
    [ServiceContract(Name = "OrderService", Namespace = "Enferno.Services.StormConnect.Contracts.Order")]
#endif
    public interface IOrderService
    {
#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "CreateInvoice")]
#endif
        void CreateInvoice(Invoice request);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "CreateDeliveryNote")]
#endif
        void CreateDeliveryNote(DeliveryNote deliveryNote);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "CancelOrder")]
#endif
        void CancelOrder(CancelOrderRequest cancelOrderRequest);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "SendOrderStatus")]
#endif
        void SendOrderStatus(SendOrderStatusRequest statusRequest);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "CreditPayment")]
#endif
        void CreditPayment(Invoice credit);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "SendPosShipment")]
#endif
        void SendPosShipment(Shipment shipment);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "CreateWarehouseTransaction")]
#endif
        void CreateWarehouseTransaction(WarehouseTransaction warehouseTransaction);

#if !NETCORE
        [OperationContract]
        [WebInvoke(UriTemplate = "CreateReceipt")]
#endif
        void CreateReceipt(Receipt request);
    }
}
