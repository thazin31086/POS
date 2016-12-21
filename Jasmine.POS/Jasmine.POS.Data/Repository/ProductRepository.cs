using Jasmine.POS.Common.Models;
using Jasmine.POS.Data.EntityModelMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jasmine.POS.Data.Repository
{
    public class ProductRepository :IRepository<ProductModel>
    {
        private readonly JasminePOSDBContext _POSDBContext;        

        public ProductRepository(JasminePOSDBContext POSDBContext)
        {
            _POSDBContext = POSDBContext ?? new JasminePOSDBContext();
        }

        public IList<ProductModel> GetAll()
        {           
            List<ProductModel> productsmodel = new List<ProductModel>();
            try
            {
                var _products = _POSDBContext.Products.ToList();
                if (_products != null)
                {
                    productsmodel = _products.ProductsToProductsModelMapper();
                }
            }
            catch (Exception)
            {
                //ToDo: Log error   
            }
            return productsmodel;
        }

        public ProductModel GetById(int Id)
        {
            ProductModel productmodel = new ProductModel();
            try
            {
                var _product = _POSDBContext.Products.SingleOrDefault(p => p.ProductID == Id);
                if (_product != null)
                {
                    productmodel = _product.ProductToProductModelMapper();
                }
            }
            catch (Exception)
            {
               //ToDo Log Error 
            }
            return productmodel;
        }

        
        public OperationStatus Save(ProductModel model)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                if (model == null)
                    throw new Exception("Invalid Record");

                Product product = model.ProductModelToProductMapper();
                _POSDBContext.Products.Add(product);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
                result.InnerExceptionMessage = ex.InnerException.ToString();
            }
            return result; 
        }

        public OperationStatus Delete(int productId)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                var product = _POSDBContext.Products.FirstOrDefault(x => x.ProductID == productId);
                if (product == null)
                    throw new Exception("Product does not exist.");

                _POSDBContext.Products.Remove(product);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                result.InnerExceptionMessage = ex.InnerException.ToString();
                //ToDo: Log error
            }

            return result;
        }


        public IList<ProductModel> GetByCategoryID(int categoryId)
        {
            List<ProductModel> productsmodel = new List<ProductModel>();
            try
            {
                var _products = _POSDBContext.Products.
                                 Where(p => p.ProductCategoryID == categoryId).ToList();
                if (_products != null)
                {
                    productsmodel = _products.ProductsToProductsModelMapper();
                }
            }
            catch (Exception)
            {
                //ToDo Log Error 
            }
            return productsmodel;
        }

    }
}
