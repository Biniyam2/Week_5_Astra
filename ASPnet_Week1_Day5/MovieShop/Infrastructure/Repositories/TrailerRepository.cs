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
    public class TrailerRepository : IRepository<Trailer>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public TrailerRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(Trailer type)
        {
            _movieDb.Trailers.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<Trailer> GetAll()
        {
            var trailer = _movieDb.Trailers;
            return trailer;
        }

        public Trailer GetById(int id)
        {
            var trailer = _movieDb.Trailers.Find(id);
            return trailer;
        }

        public void Insert(Trailer type)
        {
            _movieDb.Trailers.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(Trailer item)
        {
            throw new NotImplementedException();
        }

        public void Update(Trailer type)
        {
            _movieDb.Trailers.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
