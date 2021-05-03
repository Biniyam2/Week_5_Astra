using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response.UserRoleResponse
{
    public class FetchUserRoleResponse
    {
        public int UserRolePerPage { get; set; }
        public bool HasPerviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable< UserRole> UserRole { get; set; }
    }
}
