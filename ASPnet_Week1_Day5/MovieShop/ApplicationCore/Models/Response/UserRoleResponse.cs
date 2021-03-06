using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class UserRoleResponse
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }

        public UserResponse User { get; set; }
        public RoleResponse Role { get; set; }
    }
}
