using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
        Task<List<MovieResponse>> GetTop30RevenueMovie();
        Task<List<MovieResponse>> GetMoviesByGenreAsync(int id);
        public Task<List<MovieResponse>> GetAllMoviesAsync();
        public Task<MovieResponse> GetMovieByIdAsync(int id);
        public void AddAsync(MovieRequest movieRequest);
        public void DeleteAsync(MovieRequest movieRequest);
        public void UpdateAsync(MovieRequest movieRequest);
    }
}
