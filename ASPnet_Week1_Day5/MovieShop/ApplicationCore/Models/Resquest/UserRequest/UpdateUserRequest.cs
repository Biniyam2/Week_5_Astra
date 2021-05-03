using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.UserRequest
{
    public class UpdateUserRequest
    {
        public User User { get; set; }
        public int Id { get; set; }
    }
}
