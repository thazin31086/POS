using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Jasmine.POS.Common.Models
{
    public class RoleModel
    {
        public int RoleID { get; set; }

        [StringLength(300)]
        public string Description { get; set; }
      
        public virtual ICollection<UserModel> Users { get; set; }
    }
}
