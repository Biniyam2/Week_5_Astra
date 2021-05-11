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
    public class TrailerService : ITrailerService
    {
        private readonly ITrailerRepository _repository;
        public TrailerService(ITrailerRepository repository)
        {
            _repository = repository;
        }

        public async Task<TrailerResponse> AddAsync(TrailerRequest trailerRequest)
        {
            
            Trailer trailer = new Trailer() {
                MovieId = trailerRequest.MovieId,
            TrailerUrl = trailerRequest.TrailerUrl,
            Name = trailerRequest.Name
            };
            var tr = await _repository.AddAsync(trailer);
            TrailerResponse trailerResponse = new TrailerResponse()
            {
                Id = tr.Id,
                MovieId = tr.MovieId,
                TrailerUrl = tr.TrailerUrl,
                Name = tr.Name
            };
            return trailerResponse;

        }

        public async void DeleteAsync(TrailerRequest trailerRequest)
        {
         
            Trailer trailer = new Trailer()
            {
                MovieId = trailerRequest.MovieId,
                TrailerUrl = trailerRequest.TrailerUrl,
                Name = trailerRequest.Name
            };
            await _repository.DeleteAsync(trailer);
        }

        public async Task<List<TrailerResponse>> GetAllTrailersAsync()
        {
            var tr =await _repository.ListAllAsync();
            List<TrailerResponse> trailerResponses = new List<TrailerResponse>();
            foreach (var item in tr)
            {
                trailerResponses.Add(new TrailerResponse {
                    MovieId = item.MovieId,
                    TrailerUrl = item.TrailerUrl,
                    Name = item.Name
                });
            }
            return trailerResponses;
        }

        public async Task<TrailerResponse> GetTrailerByIdAsync(int id)
        {
            var tr =await _repository.GetByIdAsync(id);
            TrailerResponse trailerResponse = new TrailerResponse() {
                MovieId = tr.MovieId,
                TrailerUrl = tr.TrailerUrl,
                Name = tr.Name
            };
            return trailerResponse;
        }

        public async Task<TrailerResponse> UpdateAsync(TrailerRequest trailerRequest)
        {
          
            Trailer trailer = new Trailer()
            {
                MovieId = trailerRequest.MovieId,
                TrailerUrl = trailerRequest.TrailerUrl,
                Name = trailerRequest.Name
            };
         
            var tr = await _repository.UpdateAsync(trailer);
            TrailerResponse trailerResponse = new TrailerResponse()
            {
                Id = tr.Id,
                MovieId = tr.MovieId,
                TrailerUrl = tr.TrailerUrl,
                Name = tr.Name
            };
            return trailerResponse;
        }
    }
}
