using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.MovieGenreRequest
{
    public class UpdateMovieGenreRequest
    {
        public MovieGenre MovieGenre { get; set; }
        public int Id { get; set; }
    }
}
