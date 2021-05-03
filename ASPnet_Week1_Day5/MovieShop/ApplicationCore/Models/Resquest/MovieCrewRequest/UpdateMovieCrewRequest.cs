using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.MovieCrewRequest
{
    public  class UpdateMovieCrewRequest
    {
        public MovieCrew MovieCrew { get; set; }
        public int Id { get; set; }
    }
}
