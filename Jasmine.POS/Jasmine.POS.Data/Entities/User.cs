namespace Jasmine.POS.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(200)]
        public string FirstName { get; set; }

        [StringLength(200)]
        public string LastName { get; set; }

        public int? RoleID { get; set; }

        [StringLength(50)]
        public string TFN { get; set; }

        [StringLength(50)]
        public string mobile { get; set; }

        [StringLength(400)]
        public string address { get; set; }

        public virtual Role Role { get; set; }
    }
}
