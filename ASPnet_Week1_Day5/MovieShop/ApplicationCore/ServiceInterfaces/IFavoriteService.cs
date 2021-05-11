using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IFavoriteService
    {
        public Task<List<FavoriteResponse>> GetAllFavoritesAsync();
        public Task<FavoriteResponse> GetFavoriteByIdAsync(int id);
        public Task<FavoriteResponse> AddAsync(FavoriteRequest favoriteRequest);
        public void DeleteAsync(FavoriteRequest favoriteRequest);
        public Task<FavoriteResponse> UpdateAsync(FavoriteRequest favoriteRequest);
    }
}
