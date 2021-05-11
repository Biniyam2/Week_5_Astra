using ApplicationCore.Entites;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly IFavoriteRepository _repository;
        
        public FavoriteService(IFavoriteRepository repository)
        {
            _repository = repository;
        }

        public async Task<FavoriteResponse> AddAsync(FavoriteRequest favoriteRequest)
        {
           
            Favorite favorite = new Favorite() { 
              MovieId = favoriteRequest.MovieId,
              UserId = favoriteRequest.UserId
            };
          var fav = await _repository.AddAsync(favorite);
            FavoriteResponse favoriteResponse = new FavoriteResponse()
            {
                Id = fav.Id,
                UserId = fav.UserId,
                MovieId = fav.MovieId
            };
            return favoriteResponse;
        }

        public async void DeleteAsync(FavoriteRequest favoriteRequest)
        {
           
            Favorite favorite = new Favorite()
            {
                MovieId = favoriteRequest.MovieId,
                UserId = favoriteRequest.UserId
            };
            await _repository.DeleteAsync(favorite);
        }

        public async Task<List<FavoriteResponse>> GetAllFavoritesAsync()
        {
            var favs =await _repository.ListAllAsync();
            List<FavoriteResponse> favoriteResponses = new List<FavoriteResponse>();
            foreach (var item in favs)
            {
                favoriteResponses.Add(
                    new FavoriteResponse()
                    {
                        Id = item.Id,
                        UserId = item.UserId,
                        MovieId = item.MovieId
                    } );
            }
            return favoriteResponses;
        }

        public async Task<FavoriteResponse> GetFavoriteByIdAsync(int id)
        {
            var fav = await _repository.GetByIdAsync(id);
            FavoriteResponse favoriteResponse = new FavoriteResponse() {
                Id = fav.Id,
                UserId = fav.UserId,
                MovieId = fav.MovieId
            };
            return favoriteResponse;
        }

        public async Task<FavoriteResponse> UpdateAsync(FavoriteRequest favoriteRequest)
        {
          
            Favorite favorite = new Favorite()
            {
                MovieId = favoriteRequest.MovieId,
                UserId = favoriteRequest.UserId
            };
            var fav = await _repository.UpdateAsync(favorite);
            FavoriteResponse favoriteResponse = new FavoriteResponse()
            {
                Id = fav.Id,
                UserId = fav.UserId,
                MovieId = fav.MovieId
            };
            return favoriteResponse;
        }
    }
}
