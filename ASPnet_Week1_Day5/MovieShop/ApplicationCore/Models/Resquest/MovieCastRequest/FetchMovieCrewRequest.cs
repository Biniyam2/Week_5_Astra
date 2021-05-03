using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.MovieCastRequest
{
    public class FetchMovieCrewRequest
    {
        public int PageNumebr { get; set; }
        public int MovieCastsPerPage { get; set; }
    }
}
