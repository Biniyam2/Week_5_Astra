using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;
using Infrastructure.Data;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class UserRepository : EfRepository<User> , IUserRepository
    {
        public UserRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}
