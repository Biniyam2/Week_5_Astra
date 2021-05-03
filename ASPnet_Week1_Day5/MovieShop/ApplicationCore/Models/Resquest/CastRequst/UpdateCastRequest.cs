
using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.CastRequst
{
    public class UpdateCastRequest
    {
        public Cast Cast { get; set; }
        public int Id { get; set; }
    }
}
