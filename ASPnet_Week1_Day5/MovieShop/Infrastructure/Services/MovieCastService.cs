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
    public class MovieCastService : IMovieCastService
    {
        private readonly IMovieCastRepository _repository;
        public MovieCastService(IMovieCastRepository repository)
        {
            _repository = repository;
        }

        public async void AddAsync()
        {
            MovieCastRequest movieCastRequest = new MovieCastRequest();
            MovieCast movieCast = new MovieCast() { 
             MovieId = movieCastRequest.MovieId,
             CastId = movieCastRequest.CastId,
             Character = movieCastRequest.Character
            };
            await _repository.AddAsync(movieCast);
        }

        public async void DeleteAsync()
        {
            MovieCastRequest movieCastRequest = new MovieCastRequest();
            MovieCast movieCast = new MovieCast()
            {
                MovieId = movieCastRequest.MovieId,
                CastId = movieCastRequest.CastId,
                Character = movieCastRequest.Character
            };
            await _repository.DeleteAsync(movieCast);
        }

        public async Task<List<MovieCastResponse>> GetAllMovieCastsAsync()
        {
            var mc =await _repository.ListAllAsync();
            List< MovieCastResponse> movieCastResponses = new List<MovieCastResponse>();
            foreach (var item in mc)
            {
                movieCastResponses.Add(new MovieCastResponse {
                    MovieId = item.MovieId,
                    CastId = item.CastId,
                    Character = item.Character
                });
            }
            return movieCastResponses;
        }

        public async Task<MovieCastResponse> GetMovieCastByIdAsync(int id)
        {
            var mc = await _repository.GetByIdAsync(id);
            MovieCastResponse movieCastResponse = new MovieCastResponse() {
                MovieId = mc.MovieId,
                CastId = mc.CastId,
                Character = mc.Character
            };
            return movieCastResponse;
        }

        public async void UpdateAsync()
        {
            MovieCastRequest movieCastRequest = new MovieCastRequest();
            MovieCast movieCast = new MovieCast()
            {
                MovieId = movieCastRequest.MovieId,
                CastId = movieCastRequest.CastId,
                Character = movieCastRequest.Character
            };
            await _repository.UpdateAsync(movieCast);
        }
    }
}
