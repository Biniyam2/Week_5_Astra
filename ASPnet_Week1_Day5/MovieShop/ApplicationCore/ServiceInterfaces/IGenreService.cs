using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IGenreService
    {
        public Task<List<GenreResponse>> GetAllGenresAsync();
        public Task<GenreResponse> GetGenreByIdAsync(int id);
        public void AddAsync(GenreRequest genreRequest);
        public void DeleteAsync(GenreRequest genreRequest);
        public void UpdateAsync(GenreRequest genreRequest);
    }
}
