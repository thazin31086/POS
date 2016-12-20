using Jasmine.POS.Common.Models;
using System.Collections.Generic;

namespace Jasmine.POS.Data.IRepository
{
    public interface IProductRepository
    {
        IList<ProductModel> GetAllProducts();
        ProductModel GetProductsById(int productId);
        IList<ProductModel> GetProductsByCategoryID(int categoryId);

        OperationStatus Save(ProductModel productmodel);
        OperationStatus Delete(int productId);
    }
}