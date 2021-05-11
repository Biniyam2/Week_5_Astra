using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IRoleService
    {
        public Task<List<RoleResponse>> GetAllRolesAsync();
        public Task<RoleResponse> GetRoleByIdAsync(int id);
        public Task<RoleResponse> AddAsync(RoleRequest roleRequest);
        public void DeleteAsync(RoleRequest roleRequest);
        public Task<RoleResponse> UpdateAsync(RoleRequest roleRequest);
    }
}
