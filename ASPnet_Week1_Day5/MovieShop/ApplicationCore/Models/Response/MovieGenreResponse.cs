using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class MovieGenreRequest
    {
     
        public int MovieId { get; set; }
        public int GenreId { get; set; }
    }
}
