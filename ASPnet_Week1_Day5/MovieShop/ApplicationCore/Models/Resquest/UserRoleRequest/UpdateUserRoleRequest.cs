using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.UserRoleRequest
{
    public class UpdateUserRoleRequest
    {
        public UserRole UserRole { get; set; }
        public int Id { get; set; }
    }
}
