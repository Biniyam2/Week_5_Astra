using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Response;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.Models.Response.MovieResponse;
using ApplicationCore.Models.Resquest.MovieRequest;
using ApplicationCore.ServiceInterfaces;
using ApplicationCore.Entites;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        public MovieService( IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public DeleteMovieResponse Delete(DeleteMovieRequest deleteGenreRequest)
        {
            
            var movie = _movieRepository.GetById(deleteGenreRequest.Id);
            _movieRepository.Delete(movie);
            return new DeleteMovieResponse { Movie = movie };
        }

        public FetchMovieResponse GetMovies(FetchMovieRequest fetchGenreRequest)
        {
            var movies = _movieRepository.GetAll();
            return new FetchMovieResponse()
            {
                Movie = movies
            };
        }

        public GetMovieResponse GetMovie(GetMovieRequest getGenreRequest)
        {
            GetMovieResponse movieResponse = new GetMovieResponse();
            movieResponse.Movie = _movieRepository.GetById(getGenreRequest.Id);
            return movieResponse;
       
        }

        public CreateMovieResponse Insert(CreateMovieRequest createMovieRequest)
        {
           
            _movieRepository.Insert(createMovieRequest.Movie);
            return new CreateMovieResponse();
        }

        public UpdateMovieResponse Update(UpdateMovieRequest updateGenreRequest)
        {
            var movie = _movieRepository.GetById(updateGenreRequest.Id);
            _movieRepository.Update(updateGenreRequest.Movie);
            return new UpdateMovieResponse { Movie = movie };
        }
      
    }
}
