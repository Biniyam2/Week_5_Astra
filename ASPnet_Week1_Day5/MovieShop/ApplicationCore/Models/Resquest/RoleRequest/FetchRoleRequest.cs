using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.RoleRequest
{
    public class FetchRoleRequest
    {
        public int PageNumber { get; set; }
        public int RolePerPage { get; set; }
    }
}
