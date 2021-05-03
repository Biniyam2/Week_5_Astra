using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.UserRequest
{
    public class  FetchUserRequest
    {
        public int PageNumber { get; set; }
        public int UsersPerPage { get; set; }
    }
}
