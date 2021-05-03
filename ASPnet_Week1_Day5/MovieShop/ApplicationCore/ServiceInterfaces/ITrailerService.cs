using ApplicationCore.Models.Response.TrailerResponse;
using ApplicationCore.Models.Resquest.TrailerRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ITrailerService
    {
        public CreateTrailerResponse Insert(CreateTrailerRequest createTrailerRequest);
        public DeleteTrailerResponse Delete(DeleteTrailerRequest deleteTrailerRequest);
        public UpdateTrailerResponse Update(UpdateTrailerRequest updateTrailerRequest);
        public GetTrailerResponse GetTrailer(GetTrailerRequest getTrailerRequest);
        public FetchTrailerResponse GetTrailers(FetchTrailerRequest fetchTrailerRequest);
    }
}
