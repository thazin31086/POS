using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasmine.POS.DataServices
{    public interface IOrderRepository
    {
        IList<OrderModel> GetAllOrders();
        OrderModel GetOrderByOrderId(int OrderId);

        OperationStatus Save(OrderModel ordermodel);

        OperationStatus Delete(int orderId);

    }
}
