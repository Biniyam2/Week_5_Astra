using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.MovieRequest
{
    public class UpdateMovieRequest
    {
        public Movie Movie { get; set; }
        public int Id { get; set; }
    }
}
