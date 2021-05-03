using ApplicationCore.Models.Response.GenreResponse;
using ApplicationCore.Models.Resquest.GenreRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public  interface IGenreService
    {
        public CreateGenreResponse Insert(CreateGenreRequest createGenreRequest);
        public DeleteGenreResponse Delete(DeleteGenreRequest deleteGenreRequest);
        public UpdateGenreResponse Update(UpdateGenreRequest updateGenreRequest);
        public GetGenreResponse GetGenre(GetGenreRequest getGenreRequest);
        public FetchGenreResponse GetGenres(FetchGenreRequest fetchGenreRequest);
    }
}
