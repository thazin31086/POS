using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Jasmine.POS.Common.Models
{
    public class ProductCategoryModel
    {        
        public int ProductCategoryID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
      
        public virtual ICollection<ProductModel> Products { get; set; }
    }
}
