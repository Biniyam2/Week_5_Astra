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

        public void Add()
        {
            CastRequest castRequest = new CastRequest();
            Cast cast = new Cast() { 
                  Gender = castRequest.Gender,
                  Name = castRequest.Name,
                  TmdbUrl = castRequest.TmdbUrl,
                  ProfilePath = castRequest.ProfilePath
            };
            _castRepository.AddAsync(cast);

        }

        public void Delete()
        {
            CastRequest castRequest = new CastRequest();
            Cast cast = new Cast()
            {
                Gender = castRequest.Gender,
                Name = castRequest.Name,
                TmdbUrl = castRequest.TmdbUrl,
                ProfilePath = castRequest.ProfilePath
            };
            _castRepository.DeleteAsync(cast);
        }

        public async Task<List<CastResponse>> GetAllCasts()
        {
            var cast = await _castRepository.ListAllAsync();
            
            List<CastResponse> castResponses = new List<CastResponse>();

            foreach (var item in cast)
            {
                castResponses.Add(new CastResponse {

                    Gender = item.Gender,
                    Name = item.Name,
                    TmdbUrl = item.TmdbUrl,
                    ProfilePath = item.ProfilePath,
                    MovieCasts = (ICollection<MovieCast>)item.MovieCasts.Where(mc => mc.CastId == item.Id).Select(mc => mc.Movie)
                });
            }
            return castResponses;
        }

        public async Task<CastResponse> GetCastById(int id)
        {
            var cast =await _castRepository.GetByIdAsync(id);
            CastResponse castResponse = new CastResponse() {
                Gender = cast.Gender,
                Name = cast.Name,
                TmdbUrl = cast.TmdbUrl,
                ProfilePath = cast.ProfilePath,
                MovieCasts = (ICollection<MovieCast>)cast.MovieCasts.Where(mc => mc.CastId == cast.Id).Select(mc => mc.Movie)

            };
            return castResponse;
        }

        public async void Update()
        {
            CastRequest castRequest = new CastRequest();
            Cast cast = new Cast() {
                Gender = castRequest.Gender,
                Name = castRequest.Name,
                TmdbUrl = castRequest.TmdbUrl,
                ProfilePath = castRequest.ProfilePath
            };
            await _castRepository.UpdateAsync(cast);
        }
        
    }
}
