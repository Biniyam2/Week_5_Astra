using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieCrewService
    {
        public Task<List<MovieCrewResponse>> GetAllMovieCrewsAsync();
        public Task<MovieCrewResponse> GetMovieCrewByIdAsync(int id);
        public Task<MovieCrewResponse> AddAsync(MovieCrewRequest movieCrewRequest);
        public void DeleteAsync(MovieCrewRequest movieCrewRequest);
        public Task<MovieCrewResponse> UpdateAsync(MovieCrewRequest movieCrewRequest);
    }
}
