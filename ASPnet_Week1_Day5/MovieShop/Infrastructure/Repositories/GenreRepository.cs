using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entites;
using Infrastructure.Data;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class GenreRepository : EfRepository<Genre> ,IGenreRepository
    {
        public GenreRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
        public override async Task<Genre> GetByIdAsync(int id)
        {
            var entity = await _dbContext.Genres.Include( g => g.MovieGenres).FirstOrDefaultAsync(g => g.Id == id);
            return entity;
        }
    }
}
