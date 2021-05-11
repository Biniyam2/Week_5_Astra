using ApplicationCore.Entites;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieGenreService : IMovieGenreService
    {
        private readonly IMovieGenreRepository _repository;

        public MovieGenreService(IMovieGenreRepository repository)
        {
            _repository = repository;
        }

        public async Task<MovieGenreResponse> AddAsync(MovieGenreRequest moviegenreRequest)
        {

            MovieGenre movieGenre = new MovieGenre()
            {
                MovieId = moviegenreRequest.MovieId,
                GenreId = moviegenreRequest.GenreId
            };
            var mg = await _repository.AddAsync(movieGenre);
            MovieGenreResponse movieGenreResponse = new MovieGenreResponse()
            {
                MovieId = mg.MovieId,
                GenreId = mg.GenreId
            };
            return movieGenreResponse;
        }

        public async void DeleteAsync(MovieGenreRequest moviegenreRequest)
        {
             

            MovieGenre movieGenre = new MovieGenre()
            {
                MovieId = moviegenreRequest.MovieId,
                GenreId = moviegenreRequest.GenreId
            };
            await _repository.DeleteAsync(movieGenre);
        }

        public async Task<List<MovieGenreResponse>> GetAllMovieGenresAsync()
        {
            var mg = await _repository.ListAllAsync();
            List<MovieGenreResponse> movieGenres = new List<MovieGenreResponse>();
            foreach (var item in mg)
            {
                movieGenres.Add( new MovieGenreResponse { 
                MovieId = item.MovieId,
                GenreId = item.GenreId
                });
            }
            return movieGenres;
        }

        public async Task<MovieGenreResponse> GetMovieGenreByIdAsync(int id)
        {
            var mg = await _repository.GetByIdAsync(id);
            MovieGenreResponse movieGenreResponse = new MovieGenreResponse() { 
            MovieId = mg.MovieId,
            GenreId = mg.GenreId
            };
            return movieGenreResponse;
        }

        public async Task<MovieGenreResponse> UpdateAsync(MovieGenreRequest moviegenreRequest)
        {
            MovieGenre movieGenre = new MovieGenre()
            {
                MovieId = moviegenreRequest.MovieId,
                GenreId = moviegenreRequest.GenreId
            };
            var mg = await _repository.UpdateAsync(movieGenre);
            MovieGenreResponse movieGenreResponse = new MovieGenreResponse()
            {
                MovieId = mg.MovieId,
                GenreId = mg.GenreId
            };
            return movieGenreResponse;
        }
    }
}
