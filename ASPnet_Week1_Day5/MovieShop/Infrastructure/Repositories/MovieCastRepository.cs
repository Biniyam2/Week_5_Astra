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
     public class MovieCastRepository : IRepository<MovieCast>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public MovieCastRepository (MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(MovieCast type)
        {
            _movieDb.MovieCasts.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<MovieCast> GetAll()
        {
            var mc = _movieDb.MovieCasts;
            return mc;
        }

        public MovieCast GetById(int id)
        {
            var mc = _movieDb.MovieCasts.Find(id);
            return mc;
        }

        public void Insert(MovieCast type)
        {
            var mc = _movieDb.MovieCasts.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(MovieCast item)
        {
            throw new NotImplementedException();
        }

        public void Update(MovieCast type)
        {
            _movieDb.MovieCasts.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
