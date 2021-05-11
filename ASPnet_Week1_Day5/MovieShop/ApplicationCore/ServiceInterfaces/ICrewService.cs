using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICrewService
    {
        public Task<List<CrewResponse>> GetAllCrewsAsync();
        public Task<CrewResponse> GetCrewByIdAsync(int id);
        public Task<CrewResponse> AddAsync(CrewRequest crewRequest);
        public void DeleteAsync(CrewRequest crewRequest);
        public Task<CrewResponse> UpdateAsync(CrewRequest crewRequest);
    }
}
