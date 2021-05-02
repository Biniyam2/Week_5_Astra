using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;
using Infrastructure.Data;
using ApplicationCore.RepsoitoryInterfaces;

namespace Infrastructure.Repositories
{
    public class UserRoleRepository : IRepository<UserRole>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public UserRoleRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(UserRole type)
        {
            _movieDb.UserRoles.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<UserRole> GetAll()
        {
            var userRole = _movieDb.UserRoles;
            return userRole;
        }

        public UserRole GetById(int id)
        {
            var userRole = _movieDb.UserRoles.Find(id);
            return userRole;
        }

        public void Insert(UserRole type)
        {
            _movieDb.UserRoles.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(UserRole item)
        {
            throw new NotImplementedException();
        }

        public void Update(UserRole type)
        {
            _movieDb.UserRoles.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
