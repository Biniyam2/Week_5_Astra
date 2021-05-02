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
    public class PurchaseRepository : IRepository<Purchase>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public PurchaseRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(Purchase type)
        {
            _movieDb.Purchases.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<Purchase> GetAll()
        {
            var pur = _movieDb.Purchases;
            return pur;
        }

        public Purchase GetById(int id)
        {
            var pur = _movieDb.Purchases.Find(id);
            return pur;
        }

        public void Insert(Purchase type)
        {
            _movieDb.Purchases.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(Purchase item)
        {
            throw new NotImplementedException();
        }

        public void Update(Purchase type)
        {
            _movieDb.Purchases.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
