using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.UserRoleRequest
{
    public class FetchUserRoleRequest
    {
        public int PageNumber { get; set; }
        public int UserRolesPerPage { get; set; }
    }
}
