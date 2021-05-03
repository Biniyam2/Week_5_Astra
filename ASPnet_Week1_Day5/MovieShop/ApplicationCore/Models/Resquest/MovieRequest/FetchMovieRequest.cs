using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.MovieRequest
{
    public class FetchMovieRequest
    {
        public int PageNumber { get; set; }
        public int MoviesPerPage { get; set; }
    }
}
