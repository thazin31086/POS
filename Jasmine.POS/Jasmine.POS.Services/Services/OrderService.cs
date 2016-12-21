using Jasmine.POS.Common.Models;
using Jasmine.POS.Data;
using Jasmine.POS.Data.Repository;
using System.Collections.Generic;

namespace Jasmine.POS.Services
{
    public class OrderService 
    {
        private OrderRepository orderrepo;

        public OrderService(JasminePOSDBContext POSDBContext)
        {
            orderrepo = new OrderRepository(POSDBContext);
        }
        public IList<OrderModel> GetAllOrders()
        {
           return orderrepo.GetAll();
        }

        public OrderModel GetOrderByOrderId(int OrderId)
        {
           return orderrepo.GetById(OrderId);
        }

        public OperationStatus SaveOrder(OrderModel ordermodel)
        {
           return orderrepo.Save(ordermodel);
        }

        public OperationStatus DeleteOrder(int orderId)
        {
           return orderrepo.Delete(orderId);
        }
    }
}
