using ApplicationCore.Entites;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class MovieGenreService : IMovieGenreService
    {
        private readonly IMovieGenreRepository _repository;

        public MovieGenreService(IMovieGenreRepository repository)
        {
            _repository = repository;
        }

        //public DeleteMovieGenreResponse Delete(DeleteMovieGenreRequest deleteGenreRequest)
        //{
        //    var mg = _repository.GetById(deleteGenreRequest.Id);
        //    _repository.Delete(mg);
        //    return new DeleteMovieGenreResponse();
        //}

        //public GetMovieGenreResponse GetMovieGenre(GetMovieGenreRequest getGenreRequest)
        //{
        //    GetMovieGenreResponse getMovieGenreResponse = new GetMovieGenreResponse();
        //    getMovieGenreResponse.MovieGenre = _repository.GetById(getGenreRequest.Id);
        //    return new GetMovieGenreResponse();
        //}

        //public FetchMovieGenreResponse GetMovieGenres(FetchMovieGenreRequest fetchGenreRequest)
        //{
        //    throw new NotImplementedException();
        //}

        //public CreateMovieGenreResponse Insert(CreateMovieGenreRequest createGenreRequest)
        //{
        //    _repository.Insert(createGenreRequest.MovieGenre);
        //    return new CreateMovieGenreResponse();
        //}

        //public UpdateMovieGenreResponse Update(UpdateMovieGenreRequest updateGenreRequest)
        //{
        //    var mg = _repository.GetById(updateGenreRequest.Id);
        //    _repository.Update(mg);
        //    return new UpdateMovieGenreResponse();
        //}
    }
}
