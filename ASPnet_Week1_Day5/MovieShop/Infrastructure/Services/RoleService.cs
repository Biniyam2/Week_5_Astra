﻿using ApplicationCore.Entites;
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
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        public RoleService(IRoleRepository repository)
        {
            _repository = repository;
        }

        public async void AddAsync()
        {
            RoleRequest roleRequest = new RoleRequest();
            Role role = new Role() {
             Name = roleRequest.Name
            };
            await _repository.AddAsync(role);
        }

        public async void DeleteAsync()
        {
            RoleRequest roleRequest = new RoleRequest();
            Role role = new Role()
            {
                Name = roleRequest.Name
            };
            await _repository.DeleteAsync(role);
        }

        public async Task<List<RoleResponse>> GetAllRolesAsync()
        {
            var role = await _repository.ListAllAsync();
            List<RoleResponse> roleResponses = new List<RoleResponse>();
            foreach (var item in role)
            {
                roleResponses.Add(new RoleResponse { Id = item.Id, Name = item.Name});
            }
            return roleResponses;
        }

        public async Task<RoleResponse> GetRoleByIdAsync(int id)
        {
            var role =await _repository.GetByIdAsync(id);
            RoleResponse roleResponse = new RoleResponse() {
                Id = role.Id,
                Name = role.Name,
                UserRoles = (ICollection<UserRole>)role.UserRoles.Where(mc => mc.RoleId == role.Id).Select(r => r.User)
            };
            return roleResponse;
        }

        public async void UpdateAsync()
        {
            RoleRequest roleRequest = new RoleRequest();
            Role role = new Role()
            {
                Name = roleRequest.Name
            };
            await _repository.DeleteAsync(role);
        }
    }
}
