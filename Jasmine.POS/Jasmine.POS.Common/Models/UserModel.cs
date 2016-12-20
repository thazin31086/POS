using System.ComponentModel.DataAnnotations;

namespace Jasmine.POS.Common.Models
{
    public class UserModel
    {
        [Required]
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

        public virtual RoleModel Role { get; set; }
    }
}
