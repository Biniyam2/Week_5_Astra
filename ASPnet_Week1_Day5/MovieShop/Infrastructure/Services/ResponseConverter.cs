using ApplicationCore.Entites;
using ApplicationCore.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public  class ResponseConverter
    {
        public IEnumerable<GenreResponse> GenreResponses(List<Genre> genres)
        {
            List<GenreResponse> genreResponse = new List<GenreResponse>();
            if(genres != null)
            foreach (Genre item in genres)
            {
                genreResponse.Add(new GenreResponse { Id = item.Id, Name = item.Name });
            }
            return genreResponse.ToList();
        }
        public IEnumerable<MovieGenreResponse> MovieGenresResponses(ICollection<MovieGenre> moviegenres)
        {

            List<MovieGenreResponse> movieGenreResponse = new List<MovieGenreResponse>();
            if(moviegenres != null)
            {
                foreach (MovieGenre item in moviegenres)
                {
                    movieGenreResponse.Add(new MovieGenreResponse { GenreId = item.GenreId, MovieId = item.MovieId });
                }
                return movieGenreResponse.ToList();
            }
            else
            {
                return movieGenreResponse;
            }
          
        }

        public IEnumerable<CastResponse> CastResponses(IEnumerable<Cast> cast)
        {

            List<CastResponse> castResponses = new List<CastResponse>();
            if (cast != null)
            foreach (var item in cast)
            {
                castResponses.Add(new CastResponse
                {
                    Id = item.Id,
                    Gender = item.Gender,
                    Name = item.Name,
                    TmdbUrl = item.TmdbUrl,
                    ProfilePath = item.ProfilePath,
                    MovieCasts = MovieCastResponses(  item.MovieCasts )
                });
            }
            return  castResponses.ToList();
        }


        public IEnumerable<MovieCastResponse> MovieCastResponses(ICollection<MovieCast> mc )
        {
            List<MovieCastResponse> movieCastResponses = new List<MovieCastResponse>();
            if(mc != null)
            foreach (var item in mc)
            {
                movieCastResponses.Add(new MovieCastResponse
                {
                    
                    MovieId = item.MovieId,
                    CastId = item.CastId,
                    Character = item.Character
                });
            }
            return movieCastResponses.ToList();
        }

        public List<CrewResponse> CrewsResponse(IEnumerable<Crew> casts)
        {
            List<CrewResponse> crewResponses = new List<CrewResponse>();
            if(casts != null)
            foreach (var item in casts)
            {
                crewResponses.Add(new CrewResponse
                {
                    Id = item.Id,
                    Name = item.Name,
                    Gender = item.Gender,
                    TmdbUrl = item.TmdbUrl,
                    ProfilePath = item.ProfilePath,
                    MovieCrews = MovieCrewsResponse (item.MovieCrews)
                });
            }
            return crewResponses.ToList();
        }

        public List<MovieCrewResponse> MovieCrewsResponse(ICollection<MovieCrew> mc)
        {
            List<MovieCrewResponse> movieCrewResponses = new List<MovieCrewResponse>();
            if(mc != null)
            foreach (var item in mc)
            {
                movieCrewResponses.Add(new MovieCrewResponse
                {
                    
                    MovieId = item.MovieId,
                    CrewId = item.CrewId,
                    Department = item.Department,
                    Job = item.Job
                });
            }
            return movieCrewResponses.ToList();
        }

        public IEnumerable<FavoriteResponse> FavoriteResponses(IEnumerable<Favorite> favs)
        {
            List<FavoriteResponse> favoriteResponses = new List<FavoriteResponse>();
            if(favs != null)
            foreach (var item in favs)
            {
                favoriteResponses.Add(
                    new FavoriteResponse()
                    {
                        Id = item.Id,
                        UserId = item.UserId,
                        MovieId = item.MovieId
                    });
            }
            return favoriteResponses.ToList();
        }

        public  IEnumerable<MovieResponse> MoviesResponses(IEnumerable<Movie> movies)
        {

            var movieResponses = new List<MovieResponse>();
            if (movies != null)
            {
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
            }
            return movieResponses.ToList();
        }
        public  IEnumerable<ReviewResponse> ReviewsResponses(IEnumerable<Review> rev )
        {
            List<ReviewResponse> reviewResponses = new List<ReviewResponse>();
            if(rev != null)
            foreach (var item in rev)
            {
                reviewResponses.Add(new ReviewResponse
                {
                   
                    MovieId = item.MovieId,
                    UserId = item.UserId,
                    Rating = item.Rating,
                    ReviewText = item.ReviewText
                });
            }
            return reviewResponses.ToList();
        }
        public IEnumerable<PurchaseResponse> PurchasesResponses(IEnumerable<Purchase> p)
        {
            List<PurchaseResponse> purchases = new List<PurchaseResponse>();
            if(p != null)
            foreach (var item in p)
            {
                purchases.Add(new PurchaseResponse
                {
                    Id = item.Id,
                    UserId = item.UserId,
                    PurchaseNumber = item.PurchaseNumber,
                    TotalPrice = item.TotalPrice,
                    PurchaseDateTime = item.PurchaseDateTime,
                    MovieId = item.MovieId

                });
            }
            return purchases.ToList();
        }
        public IEnumerable<RoleResponse> RolesResponses(IEnumerable<Role> role)
        {
            List<RoleResponse> roleResponses = new List<RoleResponse>();
            if(role != null)
            foreach (var item in role)
            {
                roleResponses.Add(new RoleResponse { Id = item.Id, Name = item.Name });
            }
            return roleResponses.ToList();
        }

        public IEnumerable<TrailerResponse> TrailersResponses(IEnumerable<Trailer> tr)
        {
            List<TrailerResponse> trailerResponses = new List<TrailerResponse>();
            if (tr != null)
            foreach (var item in tr)
            {
                trailerResponses.Add(new TrailerResponse
                {
                    Id = item.Id,
                    MovieId = item.MovieId,
                    TrailerUrl = item.TrailerUrl,
                    Name = item.Name
                });
            }
            return trailerResponses.ToList();
        }

        public IEnumerable<UserRoleResponse> UserRolesResponses(IEnumerable<UserRole> ur)
        {
            List<UserRoleResponse> userRoleResponses = new List<UserRoleResponse>();
            if (ur != null)
            foreach (var item in ur)
            {
                userRoleResponses.Add(new UserRoleResponse
                {
                    UserId = item.UserId,
                    RoleId = item.RoleId
                });

            }
            return userRoleResponses.ToList();
        }

        public IEnumerable<UserResponse> UsersResponses(IEnumerable<User> user)
        {
            List<UserResponse> userResponses = new List<UserResponse>();
            if(user != null)
            foreach (var item in user)
            {
                userResponses.Add(new UserResponse
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    DateOfBirth = item.DateOfBirth,
                    Email = item.Email,
                    HashedPassword = item.HashedPassword,
                    Salt = item.Salt,
                    PhoneNumber = item.PhoneNumber,
                    TwoFactorEnabled = item.TwoFactorEnabled,
                    LastLoginDateTime = item.LastLoginDateTime,
                    LockoutEndDate = item.LockoutEndDate,
                    IsLocked = item.IsLocked,
                    AccessFailedCount = item.AccessFailedCount

                });

            }
            return userResponses.ToList();
        }
    }
}
