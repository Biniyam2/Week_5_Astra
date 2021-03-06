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
using Infrastructure.Services;

namespace Infrastructure.Services
{
    public class MovieService : ResponseConverter , IMovieService 
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<List<MovieResponse>> GetAllMoviesAsync()
        {
            var movies = await _movieRepository.ListAllAsync();

            var movieResponses = new List<MovieResponse>();
            foreach (var movie in movies)
            {
                movieResponses.Add(new MovieResponse {

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
                    Title = movie.Title,
                    Rating = ReviewsResponses(movie.Reviews).Where(r => r.MovieId == movie.Id).Average(r => r.Rating),
                });
            }
            return movieResponses;
        }
        public async Task<MovieResponse> GetMovieByIdAsync(int id)
        {

            var movie = await _movieRepository.GetByIdAsync(id);

            MovieResponse movieResponse = new MovieResponse() {

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
                Title = movie.Title,
                Rating = ReviewsResponses( movie.Reviews ) .Where(r => r.MovieId == movie.Id).Average(r => r.Rating),
                Genres =   GenreResponses(   movie.MovieGenres.Select(mc => mc.Genre).ToList()),
                Casts =   CastResponses( movie.MovieCasts.Select(mc =>  mc.Cast ).ToList()),
               Reviews = ReviewsResponses(movie.Reviews).Where(r => r.MovieId == movie.Id).ToList()

            };

            return movieResponse;
        }
       
     






        public async Task<MovieResponse> AddAsync(MovieRequest movieRequest)
        {

            Movie movie = new Movie() {
                OverView = movieRequest.OverView,
                Tagline = movieRequest.Tagline,
                Revenue = movieRequest.Revenue,
                ImdbUrl = movieRequest.ImdbUrl,
                TmdbUrl = movieRequest.TmdbUrl,
                PosterUrl = movieRequest.PosterUrl,
                BackdropUrl = movieRequest.BackdropUrl,
                OriginalLanguage = movieRequest.OriginalLanguage,
                ReleaseDate = movieRequest.ReleaseDate,
                RunTime = movieRequest.RunTime,
                Price = movieRequest.Price,
                CreateDate = movieRequest.CreateDate,
                UpdateDate = movieRequest.UpdateDate,
                CreateBy = movieRequest.CreateBy,
                UpdateBy = movieRequest.UpdateBy,
                Budget = movieRequest.Budget,
                Title = movieRequest.Title
            };
            var movie2 = await _movieRepository.AddAsync(movie); ;

            MovieResponse movieResponse = new MovieResponse()
            {

                Id = movie2.Id,
                OverView = movie2.OverView,
                Tagline = movie2.Tagline,
                Revenue = movie2.Revenue,
                ImdbUrl = movie2.ImdbUrl,
                TmdbUrl = movie2.TmdbUrl,
                PosterUrl = movie2.PosterUrl,
                BackdropUrl = movie2.BackdropUrl,
                OriginalLanguage = movie2.OriginalLanguage,
                ReleaseDate = movie2.ReleaseDate,
                RunTime = movie2.RunTime,
                Price = movie2.Price,
                CreateDate = movie2.CreateDate,
                UpdateDate = movie2.UpdateDate,
                CreateBy = movie2.CreateBy,
                UpdateBy = movie2.UpdateBy,
                Budget = movie2.Budget,
                Title = movie2.Title,

            };

            return movieResponse;
        }
        public async void DeleteAsync(MovieRequest movieRequest)
        {

            Movie movie = new Movie()
            {
                Id = movieRequest.Id,
                OverView = movieRequest.OverView,
                Tagline = movieRequest.Tagline,
                Revenue = movieRequest.Revenue,
                ImdbUrl = movieRequest.ImdbUrl,
                TmdbUrl = movieRequest.TmdbUrl,
                PosterUrl = movieRequest.PosterUrl,
                BackdropUrl = movieRequest.BackdropUrl,
                OriginalLanguage = movieRequest.OriginalLanguage,
                ReleaseDate = movieRequest.ReleaseDate,
                RunTime = movieRequest.RunTime,
                Price = movieRequest.Price,
                CreateDate = movieRequest.CreateDate,
                UpdateDate = movieRequest.UpdateDate,
                CreateBy = movieRequest.CreateBy,
                UpdateBy = movieRequest.UpdateBy,
                Budget = movieRequest.Budget,
                Title = movieRequest.Title
            };
            await _movieRepository.DeleteAsync(movie);
        }
        public async Task<MovieResponse> UpdateAsync(MovieRequest movieRequest)
        {

            Movie movie = new Movie()
            {
                Id = movieRequest.Id,
                OverView = movieRequest.OverView,
                Tagline = movieRequest.Tagline,
                Revenue = movieRequest.Revenue,
                ImdbUrl = movieRequest.ImdbUrl,
                TmdbUrl = movieRequest.TmdbUrl,
                PosterUrl = movieRequest.PosterUrl,
                BackdropUrl = movieRequest.BackdropUrl,
                OriginalLanguage = movieRequest.OriginalLanguage,
                ReleaseDate = movieRequest.ReleaseDate,
                RunTime = movieRequest.RunTime,
                Price = movieRequest.Price,
                CreateDate = movieRequest.CreateDate,
                UpdateDate = movieRequest.UpdateDate,
                CreateBy = movieRequest.CreateBy,
                UpdateBy = movieRequest.UpdateBy,
                Budget = movieRequest.Budget,
                Title = movieRequest.Title
            };

            var movie2 = await _movieRepository.UpdateAsync(movie); ;

            MovieResponse movieResponse = new MovieResponse()
            {

                Id = movie2.Id,
                OverView = movie2.OverView,
                Tagline = movie2.Tagline,
                Revenue = movie2.Revenue,
                ImdbUrl = movie2.ImdbUrl,
                TmdbUrl = movie2.TmdbUrl,
                PosterUrl = movie2.PosterUrl,
                BackdropUrl = movie2.BackdropUrl,
                OriginalLanguage = movie2.OriginalLanguage,
                ReleaseDate = movie2.ReleaseDate,
                RunTime = movie2.RunTime,
                Price = movie2.Price,
                CreateDate = movie2.CreateDate,
                UpdateDate = movie2.UpdateDate,
                CreateBy = movie2.CreateBy,
                UpdateBy = movie2.UpdateBy,
                Budget = movie2.Budget,
                Title = movie2.Title,
                Rating = movie2.Reviews.Where(r => r.MovieId == movie.Id).Average(r => r.Rating),
                Genres = (IEnumerable<GenreResponse>)movie2.MovieGenres.Select(mc => mc.Genre),
                Casts = (IEnumerable<CastResponse>)movie2.MovieCasts.Select(mc => mc.Cast)

            };

            return movieResponse;
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
                });
            }

            return topMovies;
        }

        public async Task<List<MovieResponse>> GetMoviesByGenreAsync(int id)
        {
            var movies = await _movieRepository.GetByGenreAsync(id);

            var movieResponses = new List<MovieResponse>();
            foreach (var movie in movies)
            {
                movieResponses.Add(new MovieResponse
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
                });
            }

            return movieResponses;
        }

        public async Task<List<MovieResponse>> GetTopRatedMovies()
        {
            var movies = await _movieRepository.GetRatedMovies();
            int x;
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
                    Title = movie.Title,
                    Rating = ReviewsResponses(movie.Reviews).Where(r => r.MovieId == movie.Id).Average( r => r.Rating)
                }) ;
                if (topMovies.Count() == 40)
                    break;
            }

            return topMovies.OrderByDescending( t => t.Rating).ToList();
        }

      

      
    }   
}
