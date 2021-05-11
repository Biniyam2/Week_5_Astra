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
    public interface IUserService
    {
        public Task<UserResponse> ValidateUser(string email, string password);
        public Task<IEnumerable<UserResponse>> GetAllUsersAsync();
        public Task<UserResponse> GetUserByIdAsync(int id);
        public Task<UserResponse> GetUserByEmailAsync(string email);
        public Task<UserResponse> AddAsync(UserRequest userRequest);
        public void DeleteAsync(UserRequest userRequest);
        public Task<UserResponse> UpdateAsync(UserRequest userRequest);
    }
}
