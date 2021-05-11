using ApplicationCore.Entites;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository _repository;
        public UserRoleService(IUserRoleRepository repositery)
        {
            _repository = repositery;
        }

        public async Task<UserRoleResponse> AddAsync(UserRoleRequest userRoleRequest)
        {
           
            UserRole userRole = new UserRole()
            {
                UserId = userRoleRequest.UserId,
                RoleId = userRoleRequest.RoleId
            };
            var ur = await _repository.AddAsync(userRole);
            UserRoleResponse userResponse = new UserRoleResponse()
            {
                UserId = ur.UserId,
                RoleId = ur.RoleId
            };
            return userResponse;
        }

        public async void DeleteAsync(UserRoleRequest userRoleRequest)
        {
           
            UserRole userRole = new UserRole()
            {
                UserId = userRoleRequest.UserId,
                RoleId = userRoleRequest.RoleId
            };
            await _repository.DeleteAsync(userRole);
        }

        public async Task<List<UserRoleResponse>> GetAllUserRolesAsync()
        {
            var ur = await _repository.ListAllAsync();
            List<UserRoleResponse> userRoleResponses = new List<UserRoleResponse>();
            foreach (var item in ur)
            {
                userRoleResponses.Add(new UserRoleResponse {
                    UserId = item.UserId,
                    RoleId = item.RoleId
                });
              
            }
            return userRoleResponses;
        }

        public async Task<UserRoleResponse> GetUserRoleByIdAsync(int id)
        {
            var ur =await _repository.GetByIdAsync(id);
            UserRoleResponse userResponse = new UserRoleResponse() {
                UserId = ur.UserId,
                RoleId = ur.RoleId
            };
            return userResponse;
        }

        public async Task<UserRoleResponse> UpdateAsync(UserRoleRequest userRoleRequest)
        {
           
            UserRole userRole = new UserRole()
            {
                UserId = userRoleRequest.UserId,
                RoleId = userRoleRequest.RoleId
            };
            var ur = await _repository.UpdateAsync(userRole);
            UserRoleResponse userResponse = new UserRoleResponse()
            {
                UserId = ur.UserId,
                RoleId = ur.RoleId
            };
            return userResponse;
        }
    }
}
