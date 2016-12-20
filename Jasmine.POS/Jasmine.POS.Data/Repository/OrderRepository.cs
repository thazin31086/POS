using Jasmine.POS.Common.Models;
using Jasmine.POS.Data.IRepository;
using System;
using System.Collections.Generic;

namespace Jasmine.POS.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly JasminePOSDBContext _POSDBContext;       
        public OrderRepository(JasminePOSDBContext POSDBContext)
        {
            _POSDBContext = POSDBContext;

        }
        public IList<OrderModel> GetAllOrders()
        {
            List<OrderModel> ordermodel = new List<OrderModel>();
            try
            {

            }
            catch (Exception ex)
            {
                //ToDo : Log error
            }

            return ordermodel;
         
        }
        public OrderModel GetOrderByOrderId()
        {
            OrderModel ordermodel = new OrderModel();
            try
            {

            }
            catch (Exception ex)
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
