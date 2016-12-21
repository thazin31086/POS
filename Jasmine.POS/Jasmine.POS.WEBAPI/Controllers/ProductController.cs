using Jasmine.POS.Common.Models;
using System;
using System.Web.Http;

namespace Jasmine.POS.WEBAPI.Controllers
{
    public class ProductController : BaseController
    {
        public OperationStatus GetAllProducts()
        {
            OperationStatus result = new OperationStatus();
            try
            {
                var products = services.productservice.GetAllProducts();
                result.ResultData = products;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.InnerExceptionMessage = ex.InnerException.ToString(); 
            }
            return result;
        }

        public OperationStatus GetProductById(int Id)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                var product = services.productservice.GetProductsById(Id);
                result.ResultData = product;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.InnerExceptionMessage = ex.InnerException.ToString();
            }
            return result;
        }


        public OperationStatus GetProductByCategoryId(int CId)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                var product = services.productservice.GetProductsByCategoryID(CId);
                result.ResultData = product;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.InnerExceptionMessage = ex.InnerException.ToString();
            }
            return result;
        }

        public OperationStatus SaveProduct([FromBody]ProductModel model)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                result = services.productservice.SaveProduct(model);                
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.InnerExceptionMessage = ex.InnerException.ToString();
            }
            return result;
        }
    }
}
