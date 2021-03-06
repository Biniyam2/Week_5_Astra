using ApplicationCore.Entites;
using ApplicationCore.RepsoitoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieRepository : IAsyncRepository<Movie>
    {
        Task<IEnumerable<Movie>> GetTop30HighestRevenueMovies();
        Task<IEnumerable<Movie>> GetRatedMovies();
        Task<IEnumerable<Movie>> GetByGenreAsync(int id);
        
    }
}
