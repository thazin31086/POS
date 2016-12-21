using Jasmine.POS.Common.Models;
using Jasmine.POS.Data;
using Jasmine.POS.Data.Repository;
using System.Collections.Generic;

namespace Jasmine.POS.Services
{
    public class ProductServices
    {
        private ProductRepository productrepo;

        public ProductServices(JasminePOSDBContext POSDBContext)
        {
            productrepo = new ProductRepository(POSDBContext);
        }
        public IList<ProductModel> GetAllProducts()
        {
            return productrepo.GetAll();
        }
        public ProductModel GetProductsById(int productId)
        {
            return productrepo.GetById(productId);
        }
        public IList<ProductModel> GetProductsByCategoryID(int categoryId)
        {
            return productrepo.GetByCategoryID(categoryId);
        }
        public OperationStatus SaveProduct(ProductModel productmodel)
        {
            return productrepo.Save(productmodel);
        }

        public OperationStatus DeleteProduct(int productId)
        {
            return productrepo.Delete(productId);
        }
    }
}
