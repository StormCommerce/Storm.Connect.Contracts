using System;
using System.Collections.Generic;
using System.Text;

namespace Enferno.Services.StormConnect.Contracts.Order
{
    public interface IOrderRequest
    {
        Header Header { get; set; }

        string ClientOrderRef { get; set; }

        string ErpOrderNo { get; set; }
    }
}
