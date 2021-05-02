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
    public class ReviewReopsitoy : IRepository<Review>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public ReviewReopsitoy(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(Review type)
        {
            _movieDb.Reviews.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<Review> GetAll()
        {
            var rev = _movieDb.Reviews;
            return rev;
        }

        public Review GetById(int id)
        {
            var rev = _movieDb.Reviews.Find(id);
            return rev;
        }

        public void Insert(Review type)
        {
            _movieDb.Reviews.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(Review item)
        {
            throw new NotImplementedException();
        }

        public void Update(Review type)
        {
            _movieDb.Reviews.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
