
using System;
using System.ComponentModel.DataAnnotations;

namespace Jasmine.POS.Common.Models
{
    public class OrderModel
    {
        [Required]
        public int OrderID { get; set; }

        [StringLength(250)]
        public string Customer_Name { get; set; }

        public int? OrderTypeID { get; set; }
        
        public DateTime? CreatedDate { get; set; }

        public DateTime? BookingDate { get; set; }

        public int? DiscountID { get; set; }

        public int? PaymentMethodID { get; set; }
       
        public decimal? Amount_Due { get; set; }
        
        public decimal? Change_Due { get; set; }

        public virtual DiscountModel Discount { get; set; }

        public virtual OrderTypeModel OrderType { get; set; }

        public virtual PaymentMethodModel PaymentMethod { get; set; }
    }
}
