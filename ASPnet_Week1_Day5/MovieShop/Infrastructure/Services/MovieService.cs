using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Response;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.Models.Request;
using ApplicationCore.ServiceInterfaces;
using ApplicationCore.Entites;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task<List<MovieResponse>> GetTop30RevenueMovie()
        {
            var movies = await _movieRepository.GetTop30HighestRevenueMovies();

            var topMovies = new List<MovieResponse>();
            foreach (var movie in movies)
            {
                topMovies.Add(new MovieResponse
                {
                    Id = movie.Id,
                    OverView = movie.OverView,
                    Tagline = movie.Tagline,
                    Revenue = movie.Revenue,
                    ImdbUrl = movie.ImdbUrl,
                    TmdbUrl = movie.TmdbUrl,
                    PosterUrl = movie.PosterUrl,
                    BackdropUrl = movie.BackdropUrl,
                    OriginalLanguage = movie.OriginalLanguage,
                    ReleaseDate = movie.ReleaseDate,
                    RunTime = movie.RunTime,
                    Price = movie.Price,
                    CreateDate = movie.CreateDate,
                    UpdateDate = movie.UpdateDate,
                    CreateBy = movie.CreateBy,
                    UpdateBy = movie.UpdateBy,
                    Budget = movie.Budget,
                    Title = movie.Title
                }) ;
            }

            return topMovies;
        }

    
    }
}
