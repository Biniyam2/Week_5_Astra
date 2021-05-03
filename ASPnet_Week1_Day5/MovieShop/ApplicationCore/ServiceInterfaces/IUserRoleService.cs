using ApplicationCore.Models.Response.UserRoleResponse;
using ApplicationCore.Models.Resquest.UserRoleRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserRoleService
    {
        public CreateUserRoleResponse Insert(CreateUserRoleRequest createMovieRequest);
        public DeleteUserRoleResponse Delete(DeleteUserRoleRequest deleteMovieRequest);
        public UpdateUserRoleResponse Update(UpdateUserRoleRequest updateMovieRequest);
        public GetUserRoleResponse GetUserRole(GetUserRoleRequest getMovieRequest);
        public FetchUserRoleResponse GetUserRoles(FetchUserRoleRequest fetchMovieRequest);
    }
}
