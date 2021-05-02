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
    public class MovieCrewRepository : IRepository<MovieCrew>
    {
        private readonly Data.MovieShopDbContext _movieDb;
        public MovieCrewRepository(MovieShopDbContext movieDb)
        {
            _movieDb = movieDb;
        }

        public void Delete(MovieCrew type)
        {
            _movieDb.MovieCrews.Remove(type);
            _movieDb.SaveChanges();
        }

        public IEnumerable<MovieCrew> GetAll()
        {
            var mcr = _movieDb.MovieCrews;
            return mcr;
        }

        public MovieCrew GetById(int id)
        {
            var mcr = _movieDb.MovieCrews.Find(id);
            return mcr;
        }

        public void Insert(MovieCrew type)
        {
            _movieDb.MovieCrews.Add(type);
            _movieDb.SaveChanges();
        }

        public void StoreProcedure(MovieCrew item)
        {
            throw new NotImplementedException();
        }

        public void Update(MovieCrew type)
        {
            _movieDb.MovieCrews.Update(type);
            _movieDb.SaveChanges();
        }
    }
}
