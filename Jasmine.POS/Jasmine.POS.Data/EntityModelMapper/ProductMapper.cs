using Jasmine.POS.Common.Models;
using System.Collections.Generic;

namespace Jasmine.POS.Data.EntityModelMapper
{
    public static class ProductMapper
    {
        #region Entity To Model Mapper 

        public static List<ProductModel> ProductsToProductsModelMapper(this List<Product> products)
        {
            List<ProductModel> productsmodel = new List<ProductModel>();
            if (products != null)
            {
                foreach (var product in products)
                {
                    productsmodel.Add(product.ProductToProductModelMapper());
                }
            }

            return productsmodel;
        }


        /// <summary>
        /// Map Single Product
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static ProductModel ProductToProductModelMapper(this Product product)
        {
            if (product == null)
            {
                return new ProductModel();
            }

            ProductModel productmodel = new ProductModel()
            {
                ProductID = product.ProductID,
                Description = product.Description,
                SellingPrice = product.SellingPrice,
                ProductCategoryID = product.ProductCategoryID,
                ProductCategory = product.ProductCategory != null? product.ProductCategory.ProductCategoryToProductCategoryModelMapper() : null
            };

            return productmodel;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productcategory"></param>
        /// <returns></returns>
        public static ProductCategoryModel ProductCategoryToProductCategoryModelMapper(this ProductCategory productcategory)
        {
            ProductCategoryModel productcategorymodel = new ProductCategoryModel()
            {
                ProductCategoryID = productcategory.ProductCategoryID,
                Description = productcategory.Description
            };
            return productcategorymodel;
        }
        #endregion Model To Entity Mapper 

        #region Model To Entity Mapper 

        public static List<Product> ProductsToProductsModelMapper(this List<ProductModel> productsmodel)
        {
            List<Product> products = new List<Product>();
            if (productsmodel != null)
            {
                foreach (var productmodel in productsmodel)
                {
                    products.Add(productmodel.ProductModelToProductMapper());
                }
            }

            return products;
        }


        /// <summary>
        /// Map Single Product
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Product ProductModelToProductMapper(this ProductModel productmodel)
        {
            if (productmodel == null)
            {
                return new Product();
            }

            Product product = new Product()
            {
                ProductID = productmodel.ProductID,
                Description = productmodel.Description,
                SellingPrice = productmodel.SellingPrice,
                ProductCategoryID = productmodel.ProductCategoryID,
                ProductCategory = productmodel.ProductCategory !=null ? productmodel.ProductCategory.ProductCategoryModelToProductCategoryMapper() : null
            };

            return product;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productcategory"></param>
        /// <returns></returns>
        public static ProductCategory ProductCategoryModelToProductCategoryMapper(this ProductCategoryModel productcategorymodel)
        {
            ProductCategory productcategory = new ProductCategory()
            {
                ProductCategoryID = productcategorymodel.ProductCategoryID,
                Description = productcategorymodel.Description
            };
            return productcategory;
        }
        #endregion Model To Entity Mapper 
    }
}
