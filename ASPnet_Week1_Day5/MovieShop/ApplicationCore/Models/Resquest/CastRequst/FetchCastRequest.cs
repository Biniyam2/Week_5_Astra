
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.CastRequst
{
    public class FetchCastRequest
    {
        public int PageNumber { get; set; }
        public int CastsPerPage { get; set; }
    }
}
