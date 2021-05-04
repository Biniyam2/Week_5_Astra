using ApplicationCore.Entites;
using ApplicationCore.Models.Response.TrailerResponse;
using ApplicationCore.Models.Resquest.TrailerRequest;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TrailerService : ITrailerService
    {
        private readonly IRepository<Trailer> _repository;
        public TrailerService(IRepository<Trailer> repository)
        {
            _repository = repository;
        }

        public DeleteTrailerResponse Delete(DeleteTrailerRequest deleteTrailerRequest)
        {
            var tr = _repository.GetById(deleteTrailerRequest.Id);
            _repository.Delete(tr);
            return new DeleteTrailerResponse();
        }

        public GetTrailerResponse GetTrailer(GetTrailerRequest getTrailerRequest)
        {
            GetTrailerResponse getTrailerResponse = new GetTrailerResponse();
            getTrailerResponse.Trailer = _repository.GetById(getTrailerRequest.Id);
            return new GetTrailerResponse();
        }

        public FetchTrailerResponse GetTrailers(FetchTrailerRequest fetchTrailerRequest)
        {
            throw new NotImplementedException();
        }

        public CreateTrailerResponse Insert(CreateTrailerRequest createTrailerRequest)
        {
            _repository.Insert(createTrailerRequest.Trailer);
            return new CreateTrailerResponse();
        }

        public UpdateTrailerResponse Update(UpdateTrailerRequest updateTrailerRequest)
        {
            var tr = _repository.GetById(updateTrailerRequest.Id);
            _repository.Update(tr);
            return new UpdateTrailerResponse();
        }
    }
}
