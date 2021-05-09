using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        public Task<UserResponse> ValidateUser(string email, string password);
        public Task<IEnumerable<UserResponse>> GetAllUsersAsync();
        public Task<UserResponse> GetUserByIdAsync(int id);
        public Task<UserResponse> GetUserByEmailAsync(string email);
        public void AddAsync(UserRequest userRequest);
        public void DeleteAsync(UserRequest userRequest);
        public void UpdateAsync(UserRequest userRequest);
    }
}
