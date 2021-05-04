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
    public class MovieCastService : IMovieCastService
    {
        private readonly IMovieCastRepository _repository;
        public MovieCastService(IMovieCastRepository repository)
        {
            _repository = repository;
        }

        //public DeleteMovieCastResponse Delete(DeleteMovieCastRequest deleteGenreRequest)
        //{
        //    var mc = _repository.GetById(deleteGenreRequest.Id);
        //    _repository.Delete(mc);
        //    return new DeleteMovieCastResponse();
        //}

        //public GetMovieCastResponse GetMovieCast(GetMovieCastRequest getGenreRequest)
        //{
        //    GetMovieCastResponse getMovieCast = new GetMovieCastResponse();
        //    getMovieCast.MovieCast =   _repository.GetById(getGenreRequest.Id);
        //    return new GetMovieCastResponse();
        //}

        //public FetchMovieCastResponse GetMovieCasts(FetchMovieCastRequest fetchGenreRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public CreateMovieCastResponse Insert(CreateMovieCastRequest createGenreRequest)
        //{
        //    _repository.Insert(createGenreRequest.MovieCast);
        //    return new CreateMovieCastResponse();
        //}

        //public UpdateMovieCastResponse Update(UpdateMovieCastRequest updateGenreRequest)
        //{
        //    var mc = _repository.GetById(updateGenreRequest.Id);
        //    _repository.Update(mc);
        //    return new UpdateMovieCastResponse();
        //}
    }
}
