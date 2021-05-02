using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entites;
using Infrastructure.Data;
using ApplicationCore.RepsoitoryInterfaces;

namespace Infrastructure.Repositories
{
    public class CastRepository : IRepository<Cast>
    {
        private readonly MovieShopDbContext _MovieDB;

        public CastRepository(MovieShopDbContext movieDB)
        {
            _MovieDB = movieDB;
        }
        public void Delete(Cast type)
        {
            _MovieDB.Casts.Remove(type);
            _MovieDB.SaveChanges();
        }

        public IEnumerable<Cast> GetAll()
        {
            var cast = _MovieDB.Casts;
            return cast;
        }

        public  Cast GetById(int id)
        {
            var cast = _MovieDB.Casts.Find(id);
            return cast;
        }

        public void Insert(Cast type)
        {
            _MovieDB.Casts.Add(type);
            _MovieDB.SaveChanges();
        }

        public void StoreProcedure(Cast item)
        {
            throw new NotImplementedException();
        }

        public void Update(Cast type)
        {
            _MovieDB.Casts.Update(type);
            _MovieDB.SaveChanges();
        }
    }
}
