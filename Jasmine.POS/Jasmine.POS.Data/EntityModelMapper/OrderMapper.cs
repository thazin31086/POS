//using Jasmine.POS.Common.Models;
//using System.Collections.Generic;
//namespace Jasmine.POS.Data.EntityModelMapper
//{
//    public static class OrderMapper
//    {
//        #region Entity to Model Mapper
//        /// <summary>
//        /// Map List of Orders 
//        /// </summary>
//        /// <param name="users"></param>
//        /// <returns></returns>
//        public static List<UserModel> UsersToUsersModelMapper(this List<User> users)
//        {
//            List<UserModel> usersmodel = new List<UserModel>();
//            if (usersmodel != null)
//            {
//                foreach (var user in users)
//                {
//                    usersmodel.Add(user.UserToUserModelMapper());
//                }
//            }

//            return usersmodel;
//        }


//        /// <summary>
//        /// Map Single Order
//        /// </summary>
//        /// <param name="user"></param>
//        /// <returns></returns>
//        public static UserModel UserToUserModelMapper(this User user)
//        {
//            if (user == null)
//            {
//                return new UserModel();
//            }

//            UserModel usermodel = new UserModel()
//            {
//                Id = user.Id,
//                UserName = user.UserName,
//                Password = user.Password,
//                FirstName = user.FirstName,
//                LastName = user.LastName,
//                RoleID = user.RoleID,
//                Role = user.Role.RoleToRoleModelMapper(),
//                TFN = user.TFN,
//                mobile = user.mobile,
//                address = user.address
//            };

//            return usermodel;

//        }

//        public static OrderDetailsModel OrderDetailToOrderDetailModelMapper(this OrderDetail orderdetail)
//        {
//            OrderDetailsModel orderdetailmodel = new OrderDetailsModel()
//            {
//                OrderDetailID = orderdetail.OrderDetailID,
//                OrderID = orderdetail.OrderID,
//                ProductID = orderdetail.ProductID, 
//                Qty = orderdetail.Qty, 
//                Product = orderdetail.Product.ProductToProductModelMapper()
//            };
//            return orderdetailmodel;
//        }

//        public static DiscountModel DiscountToDiscountModelMapper(this Discount discount)
//        {
//            DiscountModel discountmodel = new DiscountModel()
//            {
//               DiscountID = discount.DiscountID, 
//               Description = discount.Description, 
//               Percentage = discount.Percentage
//            };
//            return discountmodel;
//        }


//        public static OrderTypeModel OrderTypeToOrderTypeModelMapper(this OrderType ordertype)
//        {
//            OrderTypeModel ordertypemodel = new OrderTypeModel()
//            {
//                OrderTypeID = ordertype.OrderTypeID, 
//                Description = ordertype.Description
//            };
//            return ordertypemodel;
//        }


//        public static PaymentMethodModel PaymentMethodToPaymentMethodModelMapper(this PaymentMethod paymentmethod)
//        {
//            PaymentMethodModel paymentmethodmodel = new PaymentMethodModel()
//            {
//                PaymentMethodID = paymentmethod.PaymentMethodID, 
//                Description = paymentmethod.Description
//            };
//            return paymentmethodmodel;
//        }

//        #endregion Entity to Model Mapper

//        #region Model to Entity Mapper
//        #endregion Model to Entity Mapper
//    }
//}
