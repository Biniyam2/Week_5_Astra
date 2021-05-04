﻿using ApplicationCore.Entites;
using ApplicationCore.Models.Response.UserResponse;
using ApplicationCore.Models.Resquest.UserRequest;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _repository;
        public UserService(IRepository<User> repository)
        {
            _repository = repository;
        }
        public DeleteUserResponse Delete(DeleteUserRequest deleteUserRequest)
        {
            var ur = _repository.GetById(deleteUserRequest.Id);
            _repository.Delete(ur);
            return new DeleteUserResponse();
        }

        public GetUserResponse GetUser(GetUserRequest getUserRequest)
        {
            GetUserResponse getUserResponse = new GetUserResponse();
            getUserResponse.User = _repository.GetById(getUserRequest.Id);
            return new GetUserResponse();
        }

        public FetchUserResponse GetUsers(FetchUserRequest fetchUserRequest)
        {
            throw new NotImplementedException();
        }

        public CreateUserResponse Insert(CreateUserRequest createUserRequest)
        {
            _repository.Insert(createUserRequest.User);
            return new CreateUserResponse();
        }

        public UpdateUserResponse Update(UpdateUserRequest updateUserRequest)
        {
            var ur = _repository.GetById(updateUserRequest.Id);
            _repository.Update(ur);
            return new UpdateUserResponse();
        }
    }
}
