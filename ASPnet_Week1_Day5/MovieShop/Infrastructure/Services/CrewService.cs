﻿using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using ApplicationCore.ServiceInterfaces;
using ApplicationCore.RepsoitoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Services
{
    public class CrewService : ICrewService
    {
       
        private readonly ICrewRepository _crewRepsoitory;
        public CrewService(ICrewRepository crewRepsoitory)
        {
            _crewRepsoitory = crewRepsoitory;
        }
        //public DeleteCrewResponse Delete(DeleteCrewRequest deleteCrewRequest)
        //{
        //    var crew  = _crewRepsoitory.GetById(deleteCrewRequest.Id);
        //    _crewRepsoitory.Delete(crew);
        //    return new DeleteCrewResponse();
        //}

        //public GetCrewResponse GetCrew(GetCrewRequest getCrewRequest)
        //{
        //    GetCrewResponse getCrew = new GetCrewResponse();
        //   getCrew.Crew = _crewRepsoitory.GetById(getCrewRequest.Id);
        //    return new GetCrewResponse();
        //}

        //public FetchCrewResponse GetCrews(FetchCrewRequest fetchCrewRequest)
        //{

        //    throw new NotImplementedException();
        //}

        //public CreateCrewResponse Insert(CreateCrewRequest createCrewRequest)
        //{
        //    _crewRepsoitory.Insert(createCrewRequest.Crew);
        //    return new CreateCrewResponse();
        //}

        //public UpdateCrewResponse Update(UpdateCrewRequest updateCrewRequest)
        //{
        //    var crew = _crewRepsoitory.GetById(updateCrewRequest.Id);
        //    _crewRepsoitory.Update(crew);
        //    return new UpdateCrewResponse();
        //}
    }
}
