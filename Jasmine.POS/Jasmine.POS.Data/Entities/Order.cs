namespace Jasmine.POS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Column("Customer Name")]
        [StringLength(250)]
        public string Customer_Name { get; set; }

        public int? OrderTypeID { get; set; }

        [Column("CreatedDate")]
        public DateTime? CreatedDate { get; set; }

        public DateTime? BookingDate { get; set; }

        public int? DiscountID { get; set; }

        public int? PaymentMethodID { get; set; }

        [Column("Amount Due")]
        public decimal? Amount_Due { get; set; }

        [Column("Change Due")]
        public decimal? Change_Due { get; set; }

        public virtual Discount Discount { get; set; }

        public virtual OrderType OrderType { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
