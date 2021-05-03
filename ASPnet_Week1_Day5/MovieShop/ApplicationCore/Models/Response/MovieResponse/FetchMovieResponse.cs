using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response.MovieResponse
{
    public class FetchMovieResponse
    {
        public int MoviesPerPage { get; set; }
        public int CurrentPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable< Movie> Movie  { get; set; }
    }
}
