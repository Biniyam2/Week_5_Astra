using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.MovieGenreRequest
{
    public class FetchMovieGenreRequest
    {
        public int PageNumber { get; set; }
        public int MovieGenresPerPage { get; set; }
    }
}
