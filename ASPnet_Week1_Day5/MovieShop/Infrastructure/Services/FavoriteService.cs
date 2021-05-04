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
        //public DeleteFavoriteResponse Delete(DeleteFavoriteRequest deleteFavoriteRequest)
        //{
        //   var favorite = _repository.GetById(deleteFavoriteRequest.Id);
        //    _repository.Delete(favorite);
        //    return new DeleteFavoriteResponse();
        //}

        //public GetFavoriteResponse GetFavorite(GetFavoriteRequest getFavoriteRequest)
        //{
        //    GetFavoriteResponse getFavorite = new GetFavoriteResponse();
        //    getFavorite.Favorite = _repository.GetById(getFavoriteRequest.Id);
        //    return new GetFavoriteResponse();

        //}

        //public FetchFavoriteResponse GetFavorites(FetchFavoriteRequest fetchFavoriteRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public CreateFavoriteResponse Insert(CreateFavoriteRequest createFavoriteRequest)
        //{
        //    _repository.Insert(createFavoriteRequest.Favorite);
        //    return new CreateFavoriteResponse();
        //}

        //public UpdateFavoriteResponse Update(UpdateFavoriteRequest updateFavoriteRequest)
        //{
        //   var fav = _repository.GetById(updateFavoriteRequest.Id);
        //    _repository.Update(fav);
        //    return new UpdateFavoriteResponse();
        //}
    }
}
