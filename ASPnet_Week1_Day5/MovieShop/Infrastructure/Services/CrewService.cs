using ApplicationCore.Models.Response;
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
    public class CrewService : ResponseConverter, ICrewService
    {
       
        private readonly ICrewRepository _crewRepsoitory;
        public CrewService(ICrewRepository crewRepsoitory)
        {
            _crewRepsoitory = crewRepsoitory;
        }

        public async Task<CrewResponse> AddAsync(CrewRequest crewRequest)
        {
        
            Crew crew = new Crew() { 
               Name = crewRequest.Name,
               Gender = crewRequest.Gender,
               TmdbUrl = crewRequest.TmdbUrl,
               ProfilePath = crewRequest.ProfilePath
            };
            var cast = await _crewRepsoitory.AddAsync(crew);
            CrewResponse castResponse = new CrewResponse()
            {

                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath
            };
            return castResponse;
        }

        public async void DeleteAsync(CrewRequest crewRequest)
        {
          
            Crew crew = new Crew()
            {
                Name = crewRequest.Name,
                Gender = crewRequest.Gender,
                TmdbUrl = crewRequest.TmdbUrl,
                ProfilePath = crewRequest.ProfilePath
            };
            await _crewRepsoitory.DeleteAsync(crew);
        }

        public async Task<List<CrewResponse>> GetAllCrewsAsync()
        {
            var casts = await _crewRepsoitory.ListAllAsync();
            List<CrewResponse> crewResponses = new List<CrewResponse>();

            foreach (var item in casts)
            {
                crewResponses.Add(new CrewResponse {
                    Name = item.Name,
                    Gender = item.Gender,
                    TmdbUrl = item.TmdbUrl,
                    ProfilePath = item.ProfilePath
                });
            }
            return crewResponses;
        }

        public async Task<CrewResponse> GetCrewByIdAsync(int id)
        {
            var cast = await _crewRepsoitory.GetByIdAsync(id);
            CrewResponse castResponse = new CrewResponse() {

                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath,
                MovieCrews = MovieCrewsResponse ( cast.MovieCrews).Where(mc => mc.CrewId == cast.Id)
            };
            return castResponse;
        }

        public async Task<CrewResponse> UpdateAsync(CrewRequest crewRequest)
        {
            Crew crew = new Crew()
            {
                Name = crewRequest.Name,
                Gender = crewRequest.Gender,
                TmdbUrl = crewRequest.TmdbUrl,
                ProfilePath = crewRequest.ProfilePath
            };
            var cast = await _crewRepsoitory.UpdateAsync(crew);
            CrewResponse castResponse = new CrewResponse()
            {

                Name = cast.Name,
                Gender = cast.Gender,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath,
                MovieCrews = MovieCrewsResponse(cast.MovieCrews).Where(mc => mc.CrewId == cast.Id)
            };
            return castResponse;
        }
      
    }
}
