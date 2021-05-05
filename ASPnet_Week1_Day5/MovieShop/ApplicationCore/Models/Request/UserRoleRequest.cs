using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Request
{
    public class UserRoleRequest
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
