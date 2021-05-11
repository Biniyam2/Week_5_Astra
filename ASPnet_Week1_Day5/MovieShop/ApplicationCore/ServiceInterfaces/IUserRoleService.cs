using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserRoleService
    {
        public Task<List<UserRoleResponse>> GetAllUserRolesAsync();
        public Task<UserRoleResponse> GetUserRoleByIdAsync(int id);
        public Task<UserRoleResponse> AddAsync(UserRoleRequest roleRequest);
        public void DeleteAsync(UserRoleRequest roleRequest);
        public Task<UserRoleResponse> UpdateAsync(UserRoleRequest roleRequest);
    }
}
