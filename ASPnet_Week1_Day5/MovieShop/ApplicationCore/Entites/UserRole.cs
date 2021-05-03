using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    [Table("UserRole")]
    public class UserRole
    {
        [ForeignKey("User"),Required,Key]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey("Role"),Required, Key]
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
