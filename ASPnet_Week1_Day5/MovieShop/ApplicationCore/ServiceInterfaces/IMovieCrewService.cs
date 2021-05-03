using ApplicationCore.Models.Response.MovieCrewResponse;
using ApplicationCore.Models.Resquest.MovieCrewRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieCrewService
    {
        public CreateMovieCrewResponse Insert(CreateMovieCrewRequest createGenreRequest);
        public DeleteMovieCrewResponse Delete(DeleteMovieCrewRequest deleteGenreRequest);
        public UpdateMovieCrewResponse Update(UpdateMovieCrewRequest updateGenreRequest);
        public GetMovieCrewResponse GetMovieCrew(GetMovieCrewRequest getGenreRequest);
        public FetchMovieCrewResponse GetMovieCrews(FetchMovieCrewRequest fetchGenreRequest);
    }
}
