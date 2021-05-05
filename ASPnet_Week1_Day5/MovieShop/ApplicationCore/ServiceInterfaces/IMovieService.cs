using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IMovieService
    {
        Task<List<MovieResponse>> GetTop30RevenueMovie();
        public Task<List<MovieResponse>> GetAllMovies();
        public Task<MovieResponse> GetMovieById(int id);
        public void Add();
        public void Delete();
        public void Update();

        //public CreateMovieResponse Insert(CreateMovieRequest createMovieRequest);
        //public DeleteMovieResponse Delete(DeleteMovieRequest deleteMovieRequest);
        //public UpdateMovieResponse Update(UpdateMovieRequest updateMovieRequest);
        //public GetMovieResponse GetMovie(GetMovieRequest getMovieRequest);
        //public FetchMovieResponse GetMovies(FetchMovieRequest fetchMovieRequest);
    }
}
