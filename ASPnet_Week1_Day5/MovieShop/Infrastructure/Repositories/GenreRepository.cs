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
    public class GenreRepository : IRepository<Genre>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public GenreRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }
        public void Delete(Genre type)
        {
            _movieDb.Genres.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<Genre> GetAll()
        {
            var gen = _movieDb.Genres;
            return gen;
        }

        public Genre GetById(int id)
        {
            var gen = _movieDb.Genres.Find(id);
            return gen;
        }

        public void Insert(Genre type)
        {
            _movieDb.Genres.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(Genre item)
        {
            throw new NotImplementedException();
        }

        public void Update(Genre type)
        {
            _movieDb.Genres.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
