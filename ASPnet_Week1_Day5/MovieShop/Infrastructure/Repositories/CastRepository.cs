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
    public class CastRepository : EfRepository<Cast>, ICastRepository
    {
        public CastRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
         
        }
        public override async Task<Cast> GetByIdAsync(int id)
        {
            var entity = await _dbContext.Casts.Include(c => c.MovieCasts).FirstOrDefaultAsync(g => g.Id == id);
            return entity;
        }
    }
}
