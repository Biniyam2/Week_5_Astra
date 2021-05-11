using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieCastService
    {
        public Task<List<MovieCastResponse>> GetAllMovieCastsAsync();
        public Task<MovieCastResponse> GetMovieCastByIdAsync(int id);
        public Task<MovieCastResponse> AddAsync(MovieCastRequest movieCastRequest);
        public void DeleteAsync(MovieCastRequest movieCastRequest);
        public Task<MovieCastResponse> UpdateAsync(MovieCastRequest movieCastRequest);
    }
}
