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
    public class UserRepository : IRepository<User>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public UserRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(User type)
        {
            _movieDb.Users.Remove(type);
            _movieDb.SaveChanges();

        }

        public IEnumerable<User> GetAll()
        {
            var user = _movieDb.Users;
            return user;
        }

        public User GetById(int id)
        {
            var user = _movieDb.Users.Find(id);
            return user;
        }

        public void Insert(User type)
        {
            _movieDb.Users.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(User item)
        {
            throw new NotImplementedException();
        }

        public void Update(User type)
        {
            _movieDb.Users.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
