using Jasmine.POS.Common.Models;
using Jasmine.POS.Data.EntityModelMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jasmine.POS.Data.Repository
{
    public class OrderRepository
    {
        private readonly JasminePOSDBContext _POSDBContext;       
        public OrderRepository()
        {
            _POSDBContext = new JasminePOSDBContext();

        }       

        public IList<OrderModel> GetAllOrders()
        {
            List<OrderModel> ordermodel = new List<OrderModel>();
            try
            {
                var _orders = _POSDBContext.Orders.ToList();
                if (_orders != null)
                {
                    ordermodel = _orders.OrdersToOrdersModelMapper();
                }
            }
            catch (Exception)
            {
                //ToDo : Log error
            }

            return ordermodel;
         
        }
        public OrderModel GetOrderByOrderId(int orderId)
        {
            OrderModel ordermodel = new OrderModel();
            try
            {
                var _order = _POSDBContext.Orders.SingleOrDefault(o => o.OrderID == orderId);
                if (_order != null)
                {
                    ordermodel = _order.OrderToOrderModelMapper();
                }
            }
            catch (Exception)
            {
                //ToDo:: Log error
            }
            return ordermodel;

        }

        public OperationStatus Save(OrderModel ordermodel)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                if (ordermodel == null)
                    throw new Exception("Invalid Record");

                Order order = ordermodel.OrderModelToOrderMapper();
                _POSDBContext.Orders.Add(order);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();    
                //ToDo: Log Error                           
            }
            return result;

        }

        public OperationStatus Delete(int orderId)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                var order = _POSDBContext.Orders.FirstOrDefault(x => x.OrderID == orderId);
                if (order == null)
                    throw new Exception("Record does not exist.");

                _POSDBContext.Orders.Remove(order);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
                //ToDo: Log Error                           
            }
            return result;
        }
    }
}
