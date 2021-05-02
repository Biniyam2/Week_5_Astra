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
    public class CrewRepository : IRepository<Crew>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public CrewRepository(Data.MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }
        public void Delete(Crew type)
        {
            _movieDb.Crews.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<Crew> GetAll()
        {
            var crew = _movieDb.Crews;
            return crew;
        }

        public Crew GetById(int id)
        {
            var crew = _movieDb.Crews.Find(id);
            return crew;
        }

        public void Insert(Crew type)
        {
            _movieDb.Crews.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(Crew item)
        {
            throw new NotImplementedException();
        }

        public void Update(Crew type)
        {
            _movieDb.Crews.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
