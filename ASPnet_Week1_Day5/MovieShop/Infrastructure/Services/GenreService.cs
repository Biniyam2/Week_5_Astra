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
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;
        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<GenreResponse> AddAsync(GenreRequest genreRequest)
        {
           

            Genre genre = new Genre()
            {
                Name = genreRequest.Name
            };
            var gen = await _genreRepository.AddAsync(genre);
            GenreResponse genreResponse = new GenreResponse()
            {
                Id = gen.Id,
                Name = gen.Name
            };
            return genreResponse;
        }

        public async void DeleteAsync(GenreRequest genreRequest)
        {
           

            Genre genre = new Genre()
            {
                Name = genreRequest.Name
            };
            await _genreRepository.DeleteAsync(genre);
       
        }

        public async Task<List<GenreResponse>> GetAllGenresAsync()
        {
            var gn =await _genreRepository.ListAllAsync();
            List<GenreResponse> genreResponses = new List<GenreResponse>();
            foreach (var item in gn)
            {
                genreResponses.Add(new GenreResponse {
                    Id = item.Id,
                    Name = item.Name,
                    MovieGenres = item.MovieGenres
                });
            }
            return genreResponses;
        }

        public async Task<GenreResponse> GetGenreByIdAsync(int id)
        {
            var gen = await _genreRepository.GetByIdAsync(id);
            GenreResponse genreResponse = new GenreResponse()
            {
                Id = gen.Id,
                Name = gen.Name
            };
            return genreResponse;
        }

        public async Task<GenreResponse> UpdateAsync(GenreRequest genreRequest)
        {
            Genre genre = new Genre()
            {
                Name = genreRequest.Name
            };
            var gen = await _genreRepository.UpdateAsync(genre);
            GenreResponse genreResponse = new GenreResponse()
            {
                Id = gen.Id,
                Name = gen.Name
            };
            return genreResponse;
        }


    }
}





