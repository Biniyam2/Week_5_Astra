using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.GenreRequest
{
    public class FetchGenreRequest
    {
        public int PageNumber { get; set; }
        public int GenresPerPage { get; set; }
    }
}
