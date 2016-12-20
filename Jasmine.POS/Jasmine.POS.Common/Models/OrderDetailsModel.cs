using System.ComponentModel.DataAnnotations;

namespace Jasmine.POS.Common.Models
{
    public class OrderDetailsModel
    {
        [Required]
        public int OrderDetailID { get; set; }
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public int? Qty { get; set; }
    }
}
