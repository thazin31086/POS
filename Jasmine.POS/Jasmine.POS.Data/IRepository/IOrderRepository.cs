using Jasmine.POS.Common.Models;
using System.Collections.Generic;

namespace Jasmine.POS.Data.IRepository
{
    public interface IOrderRepository
    {
        IList<OrderModel> GetAllOrders();
        OrderModel GetOrderByOrderId(int OrderId);

        OperationStatus Save(OrderModel ordermodel);

        OperationStatus Delete(int orderId);

    }
}
