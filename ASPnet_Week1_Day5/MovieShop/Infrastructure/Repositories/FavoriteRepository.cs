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
    public class FavoriteRepository : IRepository<Favorite>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public FavoriteRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(Favorite type)
        {
            _movieDb.Favorites.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<Favorite> GetAll()
        {
            var fav = _movieDb.Favorites;
            return fav;
        }

        public Favorite GetById(int id)
        {
            var fav = _movieDb.Favorites.Find(id);
            return fav;
        }

        public void Insert(Favorite type)
        {
            _movieDb.Favorites.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(Favorite item)
        {
            throw new NotImplementedException();
        }

        public void Update(Favorite type)
        {
            _movieDb.Favorites.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
