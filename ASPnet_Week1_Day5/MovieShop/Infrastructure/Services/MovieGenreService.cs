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

        public async void AddAsync()
        {
            MovieGenreRequest moviegenreRequest = new MovieGenreRequest();

            MovieGenre movieGenre = new MovieGenre()
            {
                MovieId = moviegenreRequest.MovieId,
                GenreId = moviegenreRequest.GenreId
            };
            await _repository.AddAsync(movieGenre);
        }

        public async void DeleteAsync()
        {
            MovieGenreRequest moviegenreRequest = new MovieGenreRequest();

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

        public async void UpdateAsync()
        {
            MovieGenreRequest moviegenreRequest = new MovieGenreRequest();

            MovieGenre movieGenre = new MovieGenre()
            {
                MovieId = moviegenreRequest.MovieId,
                GenreId = moviegenreRequest.GenreId
            };
            await _repository.UpdateAsync(movieGenre);
        }
    }
}
