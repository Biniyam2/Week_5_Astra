using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Models.Resquest.CrewRequest;
using ApplicationCore.Models.Response.CrewResponse;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICrewService
    {
       public CreateCrewResponse Insert(CreateCrewRequest createCrewRequest);
    }
}
