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
    public class MovieRepository : EfRepository<Movie> , IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext): base(dbContext)
        {
          
        }
        public async Task<IEnumerable<Movie>> GetTop30HighestRevenueMovies()
        {
            var movies = await _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30).ToListAsync();
            return movies;
        }

        public override async Task<Movie> GetByIdAsync(int id)
        {

            var movie = await _dbContext.Movies.Include(c => c.MovieCasts).ThenInclude(mc => mc.Cast).Include(m=>m.MovieGenres).ThenInclude(m=>m.Genre).Include(m => m.Reviews).FirstOrDefaultAsync(m => m.Id == id);
          
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetByGenreAsync(int id)
        {
            var movie =await  _dbContext.MovieGenres.Include(mg => mg.Movie).Where(mg => mg.GenreId == id).Select(mg => mg.Movie).ToListAsync();
            return (IEnumerable<Movie>)movie;
        }

        public async Task<IEnumerable<Movie>> GetRatedMovies()
        {
            var movies =await _dbContext.Movies.Include(m => m.Reviews).ToListAsync();
            return movies;
        }
      
    }
}
