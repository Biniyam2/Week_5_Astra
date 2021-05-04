using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;
using Infrastructure.Data;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class TrailerRepository : EfRepository<Trailer>, ITrailerRepository
    {
        public TrailerRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}
