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
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        public RoleService(IRoleRepository repository)
        {
            _repository = repository;
        }
        //public DeleteRoleResponse Delete(DeleteRoleRequest deleteRoleRequest)
        //{
        //    var role = _repository.GetById(deleteRoleRequest.Id);
        //    _repository.Delete(role);
        //    return new DeleteRoleResponse();
        //}

        //public GetRoleResponse GetRole(GetRoleRequest getRoleRequest)
        //{
        //    GetRoleResponse getRoleResponse = new GetRoleResponse();
        //    getRoleResponse.Role = _repository.GetById(getRoleRequest.Id);
        //    return new GetRoleResponse();
        //}

        //public FetchRoleResponse GetRoles(FetchRoleRequest fetchRoleRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public CreateRoleResponse Insert(CreateRoleRequest createRoleRequest)
        //{
        //    _repository.Insert(createRoleRequest.Role);
        //    return new CreateRoleResponse();
        //}

        //public UpdateRoleResponse Update(UpdateRoleRequest updateRoleRequest)
        //{
        //    var role = _repository.GetById(updateRoleRequest.Id);
        //    _repository.Update(role);
        //    return new UpdateRoleResponse();
        //}
    }
}
