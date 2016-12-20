using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Jasmine.POS.Common.Models
{
    public class DiscountModel
    {
        public int DiscountID { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
        public decimal? Percentage { get; set; }      
        public virtual ICollection<OrderModel> Orders { get; set; }
    }
}
