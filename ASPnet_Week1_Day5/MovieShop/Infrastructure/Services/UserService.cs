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
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        private string CreateSalt()
        {
            byte[] randomBytes = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }

            return Convert.ToBase64String(randomBytes);
        }
        private string CreateHashedPassword(string password, string salt)
        {
            var hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Convert.FromBase64String(salt),
                prf: KeyDerivationPrf.HMACSHA512,
                iterationCount: 10000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
        public async void AddAsync(UserRequest userRequest)
        {
            bool exist = await _repository.GetExistsAsync(m => m.Email == userRequest.Email);
            var salt = CreateSalt();
            if(exist == false)
            {
                User user = new User()
                {
                    FirstName = userRequest.FirstName,
                    LastName = userRequest.LastName,
                    DateOfBirth = userRequest.DateOfBirth,
                    Email = userRequest.Email,
                    Salt = salt,
                    HashedPassword = CreateHashedPassword( userRequest.Password, salt),
                    PhoneNumber = userRequest.PhoneNumber,
                    TwoFactorEnabled = userRequest.TwoFactorEnabled,
                    LastLoginDateTime = userRequest.LastLoginDateTime,
                    LockoutEndDate = userRequest.LockoutEndDate,
                    IsLocked = userRequest.IsLocked,
                    AccessFailedCount = userRequest.AccessFailedCount

                };
                await _repository.AddAsync(user);
            }
            else
            {
                throw new Exception("User Already exists, please try to login");
            }
           
         
        }

        public async void DeleteAsync(UserRequest userRequest)
        {
            //UserResponse userResponse = new UserResponse();
            User user = new User()
            {
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName,
                DateOfBirth = userRequest.DateOfBirth,
                Email = userRequest.Email,
                HashedPassword = userRequest.HashedPassword,
                Salt = userRequest.Salt,
                PhoneNumber = userRequest.PhoneNumber,
                TwoFactorEnabled = userRequest.TwoFactorEnabled,
                LastLoginDateTime = userRequest.LastLoginDateTime,
                LockoutEndDate = userRequest.LockoutEndDate,
                IsLocked = userRequest.IsLocked,
                AccessFailedCount = userRequest.AccessFailedCount

            };
            await _repository.DeleteAsync(user);
        }

        public async Task<IEnumerable<UserResponse>> GetAllUsersAsync()
        {
            var user =await _repository.ListAllAsync();
            List<UserResponse> userResponses = new List<UserResponse>();
            foreach (var item in user)
            {
                userResponses.Add(new UserResponse {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    DateOfBirth = item.DateOfBirth,
                    Email = item.Email,
                    HashedPassword = item.HashedPassword,
                    Salt = item.Salt,
                    PhoneNumber = item.PhoneNumber,
                    TwoFactorEnabled = item.TwoFactorEnabled,
                    LastLoginDateTime = item.LastLoginDateTime,
                    LockoutEndDate = item.LockoutEndDate,
                    IsLocked = item.IsLocked,
                    AccessFailedCount = item.AccessFailedCount,
                    Purchases = item.Purchases.Where(u => u.UserId == item.Id) ,
                    Favorites = item.Favorites.Where(u => u.UserId == item.Id),
                    UserRoles = item.UserRoles.Where(u => u.UserId == item.Id) ,
                    Reviews = item.Reviews.Where(u => u.UserId == item.Id) 

                });
              
            }
            return userResponses;
        }

        public async Task<UserResponse> GetUserByIdAsync(int id)
        {
            var user = await _repository.GetByIdAsync(id);
            UserResponse userResponses = new UserResponse() {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                HashedPassword = user.HashedPassword,
                Salt = user.Salt,
                PhoneNumber = user.PhoneNumber,
                TwoFactorEnabled = user.TwoFactorEnabled,
                LastLoginDateTime = user.LastLoginDateTime,
                LockoutEndDate = user.LockoutEndDate,
                IsLocked = user.IsLocked,
                AccessFailedCount = user.AccessFailedCount,
                Purchases = user.Purchases.Where(u => u.UserId == user.Id) ,
                Favorites = user.Favorites.Where(u => u.UserId == user.Id) ,
                UserRoles = user.UserRoles.Where(u => u.UserId == user.Id) ,
                Reviews= user.Reviews.Where(u => u.UserId == user.Id) 
            };
            return userResponses;
        }

        public async void UpdateAsync(UserRequest userRequest)
        {
            User user = new User()
            {
                Id = userRequest.Id,
                FirstName = userRequest.FirstName,
                LastName = userRequest.LastName,
                DateOfBirth = userRequest.DateOfBirth,
                Email = userRequest.Email,
                HashedPassword = userRequest.HashedPassword,
                Salt = userRequest.Salt,
                PhoneNumber = userRequest.PhoneNumber,
                TwoFactorEnabled = userRequest.TwoFactorEnabled,
                LastLoginDateTime = userRequest.LastLoginDateTime,
                LockoutEndDate = userRequest.LockoutEndDate,
                IsLocked = userRequest.IsLocked,
                AccessFailedCount = userRequest.AccessFailedCount
            };
            await _repository.UpdateAsync(user);
        }
        public async Task<UserResponse> ValidateUser(string email, string password)
        {
            // get the user info my email by using GetUserByEmail

            var dbUser = await _repository.GetUserByEmail(email);

            if (dbUser == null)
            {
                return null;
            }

            var hashedPassword = CreateHashedPassword(password, dbUser.Salt);

            if (hashedPassword == dbUser.HashedPassword)
            {
                // passwords match so create response model object

                var loginResponseModel = new UserResponse
                {
                    Id = dbUser.Id,
                    Email = dbUser.Email,
                    FirstName = dbUser.FirstName,
                    LastName = dbUser.LastName
                };
                return loginResponseModel;
            }

            return null;
        }

        public async Task<UserResponse> GetUserByEmailAsync(string email)
        {
            var user = await _repository.GetUserByEmail(email);
            UserResponse userResponses = new UserResponse()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                HashedPassword = user.HashedPassword,
                Salt = user.Salt,
                PhoneNumber = user.PhoneNumber,
                TwoFactorEnabled = user.TwoFactorEnabled,
                LastLoginDateTime = user.LastLoginDateTime,
                LockoutEndDate = user.LockoutEndDate,
                IsLocked = user.IsLocked,
                AccessFailedCount = user.AccessFailedCount
            };
            return userResponses;
        }
    }
}
