using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ITrailerService
    {
        public Task<List<TrailerResponse>> GetAllTrailersAsync();
        public Task<TrailerResponse> GetTrailerByIdAsync(int id);
        public Task<TrailerResponse> AddAsync(TrailerRequest trailerRequest);
        public void DeleteAsync(TrailerRequest trailerRequest);
        public Task<TrailerResponse> UpdateAsync(TrailerRequest trailerRequest);
    }
}
