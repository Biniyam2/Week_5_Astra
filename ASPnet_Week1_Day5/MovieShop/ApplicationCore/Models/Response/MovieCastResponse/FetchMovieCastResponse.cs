using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response.MovieCastResponse
{
    public class FetchMovieCastResponse
    {
       
        public int MovieCastPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<MovieCast> MovieCast { get; set; }

    }
}
