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

        public async void AddAsync()
        {
            GenreRequest genreRequest = new GenreRequest();

            Genre genre = new Genre()
            {
                Name = genreRequest.Name
            };
            await _genreRepository.AddAsync(genre);
        }

        public async void DeleteAsync()
        {
            GenreRequest genreRequest = new GenreRequest();

            Genre genre = new Genre()
            {
                Name = genreRequest.Name
            };
            await _genreRepository.DeleteAsync(genre);
        }

        public Task<List<GenreResponse>> GetAllGenresAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GenreResponse> GetGenreByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async void UpdateAsync()
        {
            GenreRequest genreRequest = new GenreRequest();

            Genre genre = new Genre()
            {
                Name = genreRequest.Name
            };
            await _genreRepository.UpdateAsync(genre);
        }
    }
}
