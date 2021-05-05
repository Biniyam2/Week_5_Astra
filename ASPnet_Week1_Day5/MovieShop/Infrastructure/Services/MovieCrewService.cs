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
    public class MovieCrewService : IMovieCrewService
    {
        private readonly IMovieCrewRepository _repository;

        public MovieCrewService(IMovieCrewRepository repository)
        {
            _repository = repository;
        }

        public async void AddAsync()
        {
            MovieCrewRequest movieCrewRequest = new MovieCrewRequest();
            MovieCrew movieCrew = new MovieCrew() { 
            CrewId = movieCrewRequest.CrewId,
            MovieId = movieCrewRequest.MovieId,
            Department = movieCrewRequest.Department,
            Job = movieCrewRequest.Job
            };
            await _repository.AddAsync(movieCrew);
        }

        public async void DeleteAsync()
        {
            MovieCrewRequest movieCrewRequest = new MovieCrewRequest();
            MovieCrew movieCrew = new MovieCrew()
            {
                CrewId = movieCrewRequest.CrewId,
                MovieId = movieCrewRequest.MovieId,
                Department = movieCrewRequest.Department,
                Job = movieCrewRequest.Job
            };
            await _repository.DeleteAsync(movieCrew);
        }

        public async Task<List<MovieCrewResponse>> GetAllMovieCrewsAsync()
        {
            var mc =await _repository.ListAllAsync();
            List<MovieCrewResponse> movieCrewResponses = new List<MovieCrewResponse>();
            foreach (var item in mc)
            {
                movieCrewResponses.Add( new MovieCrewResponse { 
                
                MovieId = item.MovieId,
                CrewId = item.CrewId,
                Department = item.Department,
                Job = item.Job
                });
            }
            return movieCrewResponses;
        }

        public async Task<MovieCrewResponse> GetMovieCrewByIdAsync(int id)
        {
            var mc =await _repository.GetByIdAsync(id);
            MovieCrewResponse movieCrewResponse = new MovieCrewResponse() {
                MovieId = mc.MovieId,
                CrewId = mc.CrewId,
                Department = mc.Department,
                Job = mc.Job
            };
            return movieCrewResponse;
        }

        public async void UpdateAsync()
        {
            MovieCrewRequest movieCrewRequest = new MovieCrewRequest();
            MovieCrew movieCrew = new MovieCrew()
            {
                CrewId = movieCrewRequest.CrewId,
                MovieId = movieCrewRequest.MovieId,
                Department = movieCrewRequest.Department,
                Job = movieCrewRequest.Job
            };
            await _repository.UpdateAsync(movieCrew);
        }
        
    }
}
