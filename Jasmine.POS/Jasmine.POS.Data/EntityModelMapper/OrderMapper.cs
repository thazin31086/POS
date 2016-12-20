using Jasmine.POS.Common.Models;
using System.Collections.Generic;
namespace Jasmine.POS.Data.EntityModelMapper
{
    public static class OrderMapper
    {
        #region Entity to Model Mapper
        /// <summary>
        /// Map List of Orders 
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static List<OrderModel> OrdersToOrdersModelMapper(this List<Order> orders)
        {
            List<OrderModel> ordersmodel = new List<OrderModel>();
            if (orders != null)
            {
                foreach (var order in orders)
                {
                    ordersmodel.Add(order.OrderToOrderModelMapper());
                }
            }

            return ordersmodel;
        }


        /// <summary>
        /// Map Single Order
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static OrderModel OrderToOrderModelMapper(this Order order)
        {
            if (order == null)
            {
                return new OrderModel();
            }

            OrderModel ordermodel = new OrderModel()
            {
                OrderID = order.OrderID, 
                Customer_Name = order.Customer_Name, 
                OrderTypeID = order.OrderTypeID,
                OrderType = order.OrderType.OrderTypeToOrderTypeModelMapper(), 
                CreatedDate = order.CreatedDate, 
                BookingDate = order.BookingDate, 
                DiscountID = order.DiscountID, 
                Discount = order.Discount.DiscountToDiscountModelMapper(),
                PaymentMethodID = order.PaymentMethodID, 
                PaymentMethod = order.PaymentMethod.PaymentMethodToPaymentMethodModelMapper(),
                Amount_Due = order.Amount_Due, 
                Change_Due = order.Change_Due
            };

            return ordermodel;

        }

        public static OrderDetailsModel OrderDetailToOrderDetailModelMapper(this OrderDetail orderdetail)
        {
            OrderDetailsModel orderdetailmodel = new OrderDetailsModel()
            {
                OrderDetailID = orderdetail.OrderDetailID,
                OrderID = orderdetail.OrderID,
                ProductID = orderdetail.ProductID,
                Qty = orderdetail.Qty,
                Product = orderdetail.Product.ProductToProductModelMapper()
            };
            return orderdetailmodel;
        }

        public static DiscountModel DiscountToDiscountModelMapper(this Discount discount)
        {
            DiscountModel discountmodel = new DiscountModel()
            {
                DiscountID = discount.DiscountID,
                Description = discount.Description,
                Percentage = discount.Percentage
            };
            return discountmodel;
        }


        public static OrderTypeModel OrderTypeToOrderTypeModelMapper(this OrderType ordertype)
        {
            OrderTypeModel ordertypemodel = new OrderTypeModel()
            {
                OrderTypeID = ordertype.OrderTypeID,
                Description = ordertype.Description
            };
            return ordertypemodel;
        }


        public static PaymentMethodModel PaymentMethodToPaymentMethodModelMapper(this PaymentMethod paymentmethod)
        {
            PaymentMethodModel paymentmethodmodel = new PaymentMethodModel()
            {
                PaymentMethodID = paymentmethod.PaymentMethodID,
                Description = paymentmethod.Description
            };
            return paymentmethodmodel;
        }

        #endregion Entity to Model Mapper

        #region Model to Entity Mapper

        /// <summary>
        /// Map List of Orders 
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static List<Order> OrdersModelToOrdersMapper(this List<OrderModel> ordersmodel)
        {
            List<Order> orders = new List<Order>();
            if (ordersmodel != null)
            {
                foreach (var ordermodel in ordersmodel)
                {
                    orders.Add(ordermodel.OrderModelToOrderMapper());
                }
            }

            return orders;
        }


        /// <summary>
        /// Map Single Order
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Order OrderModelToOrderMapper(this OrderModel ordermodel)
        {
            if (ordermodel == null)
            {
                return new Order();
            }

            Order order = new Order()
            {
                OrderID = ordermodel.OrderID,
                Customer_Name = ordermodel.Customer_Name,
                OrderTypeID = ordermodel.OrderTypeID,
                OrderType = ordermodel.OrderType.OrderTypeModelToOrderTypeMapper(),
                CreatedDate = ordermodel.CreatedDate,
                BookingDate = ordermodel.BookingDate,
                DiscountID = ordermodel.DiscountID,
                Discount = ordermodel.Discount.DiscountModelToDiscountMapper(),
                PaymentMethodID = ordermodel.PaymentMethodID,
                PaymentMethod = ordermodel.PaymentMethod.PaymentMethodModelToPaymentMethodMapper(),
                Amount_Due = ordermodel.Amount_Due,
                Change_Due = ordermodel.Change_Due
            };

            return order;

        }

        public static OrderDetail OrderDetailModelToOrderDetailMapper(this OrderDetailsModel ordermodeldetail)
        {
            OrderDetail orderdetail = new OrderDetail()
            {
                OrderDetailID = ordermodeldetail.OrderDetailID,
                OrderID = ordermodeldetail.OrderID,
                ProductID = ordermodeldetail.ProductID,
                Qty = ordermodeldetail.Qty,
                Product = ordermodeldetail.Product.ProductModelToProductMapper()
            };
            return orderdetail;
        }

        public static Discount DiscountModelToDiscountMapper(this DiscountModel discountmodel)
        {
            Discount discount = new Discount()
            {
                DiscountID = discountmodel.DiscountID,
                Description = discountmodel.Description,
                Percentage = discountmodel.Percentage
            };
            return discount;
        }


        public static OrderType OrderTypeModelToOrderTypeMapper(this OrderTypeModel ordertypemodel)
        {
            OrderType ordertype = new OrderType()
            {
                OrderTypeID = ordertypemodel.OrderTypeID,
                Description = ordertypemodel.Description
            };
            return ordertype;
        }


        public static PaymentMethod PaymentMethodModelToPaymentMethodMapper(this PaymentMethodModel paymentmethodmodel)
        {
            PaymentMethod paymentmethod = new PaymentMethod()
            {
                PaymentMethodID = paymentmethodmodel.PaymentMethodID,
                Description = paymentmethodmodel.Description
            };
            return paymentmethod;
        }
        #endregion Model to Entity Mapper
    }
}
