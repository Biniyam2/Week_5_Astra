using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class MovieResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string OverView { get; set; }
        public string Tagline { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Revenue { get; set; }
        public string ImdbUrl { get; set; }
        public string TmdbUrl { get; set; }
        public string PosterUrl { get; set; }
        public string BackdropUrl { get; set; }
        public string OriginalLanguage { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int? RunTime { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public decimal Rating { get; set; }
        //public IEnumerable<MovieCrew> MovieCrews { get; set; }
        //public IEnumerable<MovieCast> MovieCasts { get; set; }
        //public IEnumerable<MovieGenre> MovieGenres { get; set; }

        public IEnumerable<Crew> Crews { get; set; }
        public IEnumerable<Cast> Casts { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public IEnumerable<Review> Reviews{ get; set; }
        public IEnumerable<Favorite> Favorites { get; set; }
        public IEnumerable<Purchase> Purchases { get; set; }
        public IEnumerable<Trailer> Trailers { get; set; }
    }
}
