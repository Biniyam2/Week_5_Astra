using ApplicationCore.Entites;
using ApplicationCore.Models.Response.GenreResponse;
using ApplicationCore.Models.Resquest.GenreRequest;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> _genreRepository;
        public GenreService(IRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public DeleteGenreResponse Delete(DeleteGenreRequest deleteGenreRequest)
        {
            var gen = _genreRepository.GetById(deleteGenreRequest.Id);
            _genreRepository.Delete(gen);
            return new DeleteGenreResponse();
        }

        public GetGenreResponse GetGenre(GetGenreRequest getGenreRequest)
        {
            GetGenreResponse getGenreResponse = new GetGenreResponse();
               getGenreResponse.Genre =  _genreRepository.GetById(getGenreRequest.Id);
            return new GetGenreResponse();
        }

        public FetchGenreResponse GetGenres(FetchGenreRequest fetchGenreRequest)
        {
            throw new NotImplementedException();
        }

        public CreateGenreResponse Insert(CreateGenreRequest createGenreRequest)
        {
            _genreRepository.Insert(createGenreRequest.Genre);
            return new CreateGenreResponse();
        }

        public UpdateGenreResponse Update(UpdateGenreRequest updateGenreRequest)
        {
            var gen = _genreRepository.GetById(updateGenreRequest.Id);
            _genreRepository.Update(gen);
            return new UpdateGenreResponse();
        }
    }
}
