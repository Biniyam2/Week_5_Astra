using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.TrailerRequest
{
    public class FetchTrailerRequest
    {
        public int PageNumber { get; set; }
        public int TrailersPerPage { get; set; }
    }
}
