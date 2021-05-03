using ApplicationCore.Models.Response.MovieGenreResponse;
using ApplicationCore.Models.Resquest.MovieGenreRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieGenreServer
    {
        public CreateMovieGenreResponse Insert(CreateMovieGenreRequest createGenreRequest);
        public DeleteMovieGenreResponse Delete(DeleteMovieGenreRequest deleteGenreRequest);
        public UpdateMovieGenreResponse Update(UpdateMovieGenreRequest updateGenreRequest);
        public GetMovieGenreResponse GetMovieGenre(GetMovieGenreRequest getGenreRequest);
        public FetchMovieGenreResponse GetMovieGenres(FetchMovieGenreRequest fetchGenreRequest);
    }
}
