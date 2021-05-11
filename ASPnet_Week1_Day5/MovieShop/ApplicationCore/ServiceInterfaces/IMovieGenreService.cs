using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieGenreService
    {
        public Task<List<MovieGenreResponse>> GetAllMovieGenresAsync();
        public Task<MovieGenreResponse> GetMovieGenreByIdAsync(int id);
        public Task<MovieGenreResponse> AddAsync(MovieGenreRequest movieGenreRequest);
        public void DeleteAsync(MovieGenreRequest movieGenreRequest);
        public Task<MovieGenreResponse> UpdateAsync(MovieGenreRequest movieGenreRequest);
    }
}
