using ApplicationCore.Entites;
using ApplicationCore.Models.Response.MovieCrewResponse;
using ApplicationCore.Models.Resquest.MovieCrewRequest;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieCrewService : IMovieCrewService
    {
        private readonly IRepository<MovieCrew> _repository;

        public MovieCrewService(IRepository<MovieCrew> repository)
        {
            _repository = repository;
        }
        public CreateMovieCrewResponse Insert(CreateMovieCrewRequest createGenreRequest)
        {
            _repository.Insert(createGenreRequest.MovieCrew);
            return new CreateMovieCrewResponse();
        }

        public DeleteMovieCrewResponse Delete(DeleteMovieCrewRequest deleteGenreRequest)
        {
           var mcrew = _repository.GetById(deleteGenreRequest.Id);
            _repository.Delete(mcrew);
            return new DeleteMovieCrewResponse();
        }

        public UpdateMovieCrewResponse Update(UpdateMovieCrewRequest updateGenreRequest)
        {
            var mcrew = _repository.GetById(updateGenreRequest.Id);
            _repository.Update(mcrew);
            return new UpdateMovieCrewResponse();
        }

        public GetMovieCrewResponse GetMovieCrew(GetMovieCrewRequest getGenreRequest)
        {
            GetMovieCrewResponse getMovieCrew = new GetMovieCrewResponse();
            getMovieCrew.MovieCrew = _repository.GetById(getGenreRequest.Id);
            return new GetMovieCrewResponse();
        }

        public FetchMovieCrewResponse GetMovieCrews(FetchMovieCrewRequest fetchGenreRequest)
        {
            throw new NotImplementedException();
        }

       
    }
}
