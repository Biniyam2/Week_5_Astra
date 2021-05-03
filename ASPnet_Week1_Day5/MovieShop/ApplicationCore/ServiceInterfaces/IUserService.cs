using ApplicationCore.Models.Response.UserResponse;
using ApplicationCore.Models.Resquest.UserRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        public CreateUserResponse Insert(CreateUserRequest createUserRequest);
        public DeleteUserResponse Delete(DeleteUserRequest deleteUserRequest);
        public UpdateUserResponse Update(UpdateUserRequest updateUserRequest);
        public GetUserResponse GetUser(GetUserRequest getUserRequest);
        public FetchUserResponse GetUsers(FetchUserRequest fetchUserRequest);
    }
}
