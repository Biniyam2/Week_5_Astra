using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.MovieCrewRequest
{
    public class FetchMovieCrewRequest
    {
        public int PageNumber { get; set; }
        public int MovieCrewPerPage { get; set; }
    }
}
