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
        private readonly IUserRoleRepository _repositery;
        public UserRoleService(IUserRoleRepository repositery)
        {
            _repositery = repositery;
        }
        //public DeleteUserRoleResponse Delete(DeleteUserRoleRequest deleteMovieRequest)
        //{
        //    var ur = _repositery.GetById(deleteMovieRequest.Id);
        //    _repositery.Delete(ur);
        //    return new DeleteUserRoleResponse();
        //}

        //public GetUserRoleResponse GetUserRole(GetUserRoleRequest getMovieRequest)
        //{
        //    GetUserRoleResponse getUserRoleResponse = new GetUserRoleResponse();
        //    getUserRoleResponse.UserRole = _repositery.GetById(getMovieRequest.Id);
        //    return new GetUserRoleResponse();
        //}

        //public FetchUserRoleResponse GetUserRoles(FetchUserRoleRequest fetchMovieRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public CreateUserRoleResponse Insert(CreateUserRoleRequest createMovieRequest)
        //{
        //    _repositery.Insert(createMovieRequest.UserRole);
        //    return new CreateUserRoleResponse();
        //}

        //public UpdateUserRoleResponse Update(UpdateUserRoleRequest updateMovieRequest)
        //{
        //    var ur = _repositery.GetById(updateMovieRequest.Id);
        //    _repositery.Update(ur);
        //    return new UpdateUserRoleResponse();
        //}
    }
}
