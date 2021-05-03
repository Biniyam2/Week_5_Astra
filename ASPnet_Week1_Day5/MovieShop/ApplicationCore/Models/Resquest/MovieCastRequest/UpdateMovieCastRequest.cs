using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.MovieCastRequest
{
    public class UpdateMovieCastRequest
    {
        public MovieCast MovieCast { get; set; }
        public int Id { get; set; }
    }
}
