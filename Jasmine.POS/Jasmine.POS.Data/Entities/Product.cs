namespace Jasmine.POS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public decimal? SellingPrice { get; set; }

        public int ProductCategoryID { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
