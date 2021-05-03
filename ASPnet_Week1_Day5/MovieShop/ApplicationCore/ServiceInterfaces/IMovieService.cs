using ApplicationCore.Models.Response.MovieResponse;
using ApplicationCore.Models.Resquest.MovieRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
        public CreateMovieResponse Insert(CreateMovieRequest createMovieRequest);
        public DeleteMovieResponse Delete(DeleteMovieRequest deleteMovieRequest);
        public UpdateMovieResponse Update(UpdateMovieRequest updateMovieRequest);
        public GetMovieResponse GetMovie(GetMovieRequest getMovieRequest);
        public FetchMovieResponse GetMovies(FetchMovieRequest fetchMovieRequest);
    }
}
