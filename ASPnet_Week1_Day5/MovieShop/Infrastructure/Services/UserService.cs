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
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async void AddAsync()
        {
            UserResponse userResponse = new UserResponse();
            User user = new User() {
            FirstName = userResponse.FirstName,
            LastName = userResponse.LastName,
            DateOfBirth = userResponse.DateOfBirth,
            Email = userResponse.Email,
            HashedPassword = userResponse.HashedPassword,
            Salt = userResponse.Salt,
            PhoneNumber = userResponse.PhoneNumber,
            TwoFactorEnabled = userResponse.TwoFactorEnabled,
            LastLoginDateTime = userResponse.LastLoginDateTime,
            LockoutEndDate = userResponse.LockoutEndDate,
            IsLocked = userResponse.IsLocked,
            AccessFailedCount = userResponse.AccessFailedCount

            };
            await _repository.AddAsync(user);
        }

        public async void DeleteAsync()
        {
            UserResponse userResponse = new UserResponse();
            User user = new User()
            {
                FirstName = userResponse.FirstName,
                LastName = userResponse.LastName,
                DateOfBirth = userResponse.DateOfBirth,
                Email = userResponse.Email,
                HashedPassword = userResponse.HashedPassword,
                Salt = userResponse.Salt,
                PhoneNumber = userResponse.PhoneNumber,
                TwoFactorEnabled = userResponse.TwoFactorEnabled,
                LastLoginDateTime = userResponse.LastLoginDateTime,
                LockoutEndDate = userResponse.LockoutEndDate,
                IsLocked = userResponse.IsLocked,
                AccessFailedCount = userResponse.AccessFailedCount

            };
            await _repository.DeleteAsync(user);
        }

        public async Task<List<UserResponse>> GetAllUsersAsync()
        {
            var user =await _repository.ListAllAsync();
            List<UserResponse> userResponses = new List<UserResponse>();
            foreach (var item in user)
            {
                userResponses.Add(new UserResponse {
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
                    AccessFailedCount = item.AccessFailedCount
                });
              
            }
            return userResponses;
        }

        public async Task<UserResponse> GetUserByIdAsync(int id)
        {
            var user = await _repository.GetByIdAsync(id);
            UserResponse userResponses = new UserResponse() {
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
                Purchases = (ICollection<Purchase>)user.Purchases.Where(u => u.UserId == user.Id).Select(u => u.Movie),
                Favorites = (ICollection<Favorite>)user.Favorites.Where(u => u.UserId == user.Id).Select(u => u.Movie),
                UserRoles = (ICollection<UserRole>)user.UserRoles.Where(u => u.UserId == user.Id).Select(u => u.Role),
                Reviews = (ICollection<Review>)user.Reviews.Where(u => u.UserId == user.Id).Select(u => u.Rating)
            };
            return userResponses;
        }

        public async void UpdateAsync()
        {
            UserResponse userResponse = new UserResponse();
            User user = new User()
            {
                FirstName = userResponse.FirstName,
                LastName = userResponse.LastName,
                DateOfBirth = userResponse.DateOfBirth,
                Email = userResponse.Email,
                HashedPassword = userResponse.HashedPassword,
                Salt = userResponse.Salt,
                PhoneNumber = userResponse.PhoneNumber,
                TwoFactorEnabled = userResponse.TwoFactorEnabled,
                LastLoginDateTime = userResponse.LastLoginDateTime,
                LockoutEndDate = userResponse.LockoutEndDate,
                IsLocked = userResponse.IsLocked,
                AccessFailedCount = userResponse.AccessFailedCount

            };
            await _repository.UpdateAsync(user);
        }
    }
}
