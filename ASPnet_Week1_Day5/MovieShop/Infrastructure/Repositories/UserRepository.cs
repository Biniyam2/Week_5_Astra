using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;
using Infrastructure.Data;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRepository : EfRepository<User> , IUserRepository
    {
        public UserRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _dbContext.Users.Include(u => u.Purchases).Include(u => u.Favorites).Include(u => u.UserRoles).ThenInclude(ur => ur.Role).Include(u => u.Reviews).FirstOrDefaultAsync(u => u.Email == email);
            return user;
        }
        public override async Task<User> GetByIdAsync(int id)
        {
            //var entity = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == id);

            var entity = await _dbContext.Users.Include(u => u.Purchases).Include(u => u.Favorites).Include(u => u.UserRoles).ThenInclude(ur => ur.Role).Include(u => u.Reviews).FirstOrDefaultAsync(u => u.Id == id);
            return entity;
        }

        public override async Task<IEnumerable<User>> ListAllAsync()
        {
            var data = await _dbContext.Users.Include(u => u.Purchases).Include(u => u.Favorites).Include(u => u.UserRoles).ThenInclude(ur => ur.Role).Include(u => u.Reviews).ToListAsync();
            return data;
        }
    }
}
