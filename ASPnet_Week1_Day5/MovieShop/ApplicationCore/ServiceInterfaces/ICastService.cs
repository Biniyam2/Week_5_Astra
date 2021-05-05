using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICastService
    {
        public Task<List<CastResponse>> GetAllCasts();
        public Task<CastResponse> GetCastById(int id);
        public void Add();
        public void Delete();
        public void Update();
        //public CreateCastResponse Insert(CreateCastRequest createCastRequest);
        //public DeleteCastResponse Delete(DeleteCastRequest deleteCrewRequest);
        //public UpdateCastResponse Update(UpdateCastRequest updateCrewRequest);
        //public GetCastResponse GetCast(GetCastRequest getCrewRequest);
        //public FetchCastResponse GetCasts(FetchCastRequest fetchCrewRequest);
    }
}
