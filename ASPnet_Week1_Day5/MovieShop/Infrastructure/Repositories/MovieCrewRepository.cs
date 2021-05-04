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
    public class MovieCrewRepository : EfRepository<MovieCrew>, IMovieCrewRepository
    {
        public MovieCrewRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}
