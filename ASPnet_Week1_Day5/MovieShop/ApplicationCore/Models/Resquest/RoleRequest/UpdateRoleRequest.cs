using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.RoleRequest
{
    public class UpdateRoleRequest
    {
        public Role Role { get; set; }
        public int Id { get; set; }
    }
}
