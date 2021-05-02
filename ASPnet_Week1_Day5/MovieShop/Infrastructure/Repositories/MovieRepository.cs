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
    public class MovieRepository : IRepository<Movie>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public MovieRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(Movie type)
        {
            _movieDb.Movies.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<Movie> GetAll()
        {
            var mov = _movieDb.Movies;
            return mov;
        }

        public Movie GetById(int id)
        {
            var mov = _movieDb.Movies.Find(id);
            return mov;
        }

        public void Insert(Movie type)
        {
            _movieDb.Movies.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(Movie item)
        {
            throw new NotImplementedException();
        }

        public void Update(Movie type)
        {
            _movieDb.Movies.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
