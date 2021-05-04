using ApplicationCore.Entites;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CastService : ICastService
    {
        private readonly ICastRepository _castRepository;

        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }
        //public DeleteCastResponse Delete(DeleteCastRequest deleteCrewRequest)
        //{
        //   var cast = _castRepository.GetById(deleteCrewRequest.Id);
        //    _castRepository.Delete(cast);
        //    return new DeleteCastResponse();
        //}

        //public GetCastResponse GetCast(GetCastRequest getCrewRequest)
        //{
        //    GetCastResponse cast = new GetCastResponse();
        //    cast.Cast = _castRepository.GetById(getCrewRequest.Id);
        //    return new GetCastResponse();
        //}

        //public FetchCastResponse GetCasts(FetchCastRequest fetchCrewRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public CreateCastResponse Insert(CreateCastRequest createCastRequest)
        //{
        //    _castRepository.Insert(createCastRequest.Cast);
        //    return new CreateCastResponse();
        //}

        //public UpdateCastResponse Update(UpdateCastRequest updateCrewRequest)
        //{
        //    var cast = _castRepository.GetById(updateCrewRequest.Id);
        //    _castRepository.Update(cast);
        //    return new UpdateCastResponse();
        //}
    }
}
