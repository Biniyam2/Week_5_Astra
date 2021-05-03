using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.CrewRequest
{
    public class FetchCrewRequest
    {
        public int PageNumber { get; set; }
        public int CrewPerPage { get; set; }
    }
}
