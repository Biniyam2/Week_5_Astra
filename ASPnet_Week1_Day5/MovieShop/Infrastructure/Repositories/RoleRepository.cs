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
    public class RoleRepository : IRepository<Role>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public RoleRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(Role type)
        {
            _movieDb.Roles.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<Role> GetAll()
        {
            var role =_movieDb.Roles;
            return role;
        }

        public Role GetById(int id)
        {
            var role = _movieDb.Roles.Find(id);
            return role;
        }

        public void Insert(Role type)
        {
            _movieDb.Roles.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(Role item)
        {
            throw new NotImplementedException();
        }

        public void Update(Role type)
        {
            _movieDb.Roles.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
