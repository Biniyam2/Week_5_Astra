using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Request;
using ApplicationCore.Models.Response;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICrewService
    {
        public Task<List<CrewResponse>> GetAllCrewsAsync();
        public Task<CrewResponse> GetCrewByIdAsync(int id);
        public void AddAsync();
        public void DeleteAsync();
        public void UpdateAsync();
    }
}
