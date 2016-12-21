using Jasmine.POS.Common.Models;
using Jasmine.POS.Data.EntityModelMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jasmine.POS.Data.Repository
{
    public class ProductRepository
    {
        private readonly JasminePOSDBContext _POSDBContext;        

        public ProductRepository()
        {
            _POSDBContext = new JasminePOSDBContext();
        }

        public IList<ProductModel> GetAllProducts()
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

        public ProductModel GetProductsById(int productId)
        {
            ProductModel productmodel = new ProductModel();
            try
            {
                var _product = _POSDBContext.Products.SingleOrDefault(p => p.ProductID == productId);
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

        public IList<ProductModel> GetProductsByCategoryID(int categoryId)
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

        public OperationStatus Save(ProductModel productmodel)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                if (productmodel == null)
                    throw new Exception("Invalid Record");

                Product product = productmodel.ProductModelToProductMapper();
                _POSDBContext.Products.Add(product);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.ToString();
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
                //ToDo: Log error
            }

            return result;
        }
    }
}
