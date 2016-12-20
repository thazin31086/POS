using System.ComponentModel.DataAnnotations;

namespace Jasmine.POS.Common.Models
{
    public class ProductModel
    {
        [Required]
        public int ProductID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public decimal? SellingPrice { get; set; }

        public int ProductCategoryID { get; set; }

        public virtual ProductCategoryModel ProductCategory { get; set; }
    }
}