using ApplicationCore.Models.Response.CastResponse;
using ApplicationCore.Models.Resquest.CastRequst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICastService
    {
        public CreateCastResponse Insert(CreateCastRequest createCastRequest);
        public DeleteCastResponse Delete(DeleteCastRequest deleteCrewRequest);
        public UpdateCastResponse Update(UpdateCastRequest updateCrewRequest);
        public GetCastResponse GetCast(GetCastRequest getCrewRequest);
        public FetchCastResponse GetCasts(FetchCastRequest fetchCrewRequest);
    }
}
