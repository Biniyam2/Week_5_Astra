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
    public class MovieGenreRepository : IRepository<MovieGenre>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public MovieGenreRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(MovieGenre type)
        {
            _movieDb.MovieGenres.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<MovieGenre> GetAll()
        {
            var mg = _movieDb.MovieGenres;
            return mg;
        }

        public MovieGenre GetById(int id)
        {
            var mg = _movieDb.MovieGenres.Find(id);
            return mg;
        }

        public void Insert(MovieGenre type)
        {
            _movieDb.MovieGenres.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(MovieGenre item)
        {
            throw new NotImplementedException();
        }

        public void Update(MovieGenre type)
        {
            _movieDb.MovieGenres.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
