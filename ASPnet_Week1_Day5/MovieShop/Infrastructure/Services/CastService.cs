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
    public class CastService : ResponseConverter, ICastService
    {
        private readonly ICastRepository _castRepository;

        public CastService(ICastRepository castRepository)
        {
            _castRepository = castRepository;
        }

        public async Task<CastResponse> AddAsync(CastRequest castRequest)
        {
          
            Cast cast = new Cast() { 
                  Gender = castRequest.Gender,
                  Name = castRequest.Name,
                  TmdbUrl = castRequest.TmdbUrl,
                  ProfilePath = castRequest.ProfilePath
            };
         var castRes = await  _castRepository.AddAsync(cast);

            CastResponse castResponse = new CastResponse()
            {
                Id = castRes.Id,
                Gender = castRes.Gender,
                Name = castRes.Name,
                TmdbUrl = castRes.TmdbUrl,
                ProfilePath = castRes.ProfilePath

            };
            return castResponse;

        }
        public async Task<CastResponse> UpdateAsync(CastRequest castRequest)
        {
           
            Cast cast = new Cast()
            {
                Gender = castRequest.Gender,
                Name = castRequest.Name,
                TmdbUrl = castRequest.TmdbUrl,
                ProfilePath = castRequest.ProfilePath
            };
            var castRes = await _castRepository.UpdateAsync(cast);

            CastResponse castResponse = new CastResponse()
            {
                Id = castRes.Id,
                Gender = castRes.Gender,
                Name = castRes.Name,
                TmdbUrl = castRes.TmdbUrl,
                ProfilePath = castRes.ProfilePath

            };
            return castResponse;
        }
        public async void DeleteAsync(CastRequest castRequest)
        {
           
            Cast cast = new Cast()
            {
                Gender = castRequest.Gender,
                Name = castRequest.Name,
                TmdbUrl = castRequest.TmdbUrl,
                ProfilePath = castRequest.ProfilePath,
            };
           await _castRepository.DeleteAsync(cast);

          
        }
        public async Task<List<CastResponse>> GetAllCastsAsync()
        {
            var cast = await _castRepository.ListAllAsync();
            
            List<CastResponse> castResponses = new List<CastResponse>();

            foreach (var item in cast)
            {
                castResponses.Add(new CastResponse {
                    Id = item.Id,
                    Gender = item.Gender,
                    Name = item.Name,
                    TmdbUrl = item.TmdbUrl,
                    ProfilePath = item.ProfilePath
                });
            }
            return castResponses;
        }
        public async Task<CastResponse> GetCastByIdAsync(int id)
        {
            var cast =await _castRepository.GetByIdAsync(id);
            CastResponse castResponse = new CastResponse() {
                Id = cast.Id,
                Gender = cast.Gender,
                Name = cast.Name,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath,
                MovieCasts = MovieCastResponses(cast.MovieCasts)
            };
            return castResponse;
        }
    }
}
