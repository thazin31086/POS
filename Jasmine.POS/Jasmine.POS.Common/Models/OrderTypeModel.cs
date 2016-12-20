using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Jasmine.POS.Common.Models
{
    public class OrderTypeModel
    {
        [Required]
        public int OrderTypeID { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
       
        public virtual ICollection<OrderModel> Orders { get; set; }
    }
}

