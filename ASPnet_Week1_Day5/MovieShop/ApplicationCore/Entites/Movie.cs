using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    [Table("Movie")]
    public class Movie
    {
        [Key, Required]
        public int Id { get; set; }
        [MaxLength(256), Required]
        public string Title { get; set; }
        [MaxLength]
        public string OverView { get; set; }
        [MaxLength(512)]
        public string Tagline { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Budget { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Revenue { get; set; }
        [MaxLength(2084)]
        public string ImdbUrl { get; set; }
        [MaxLength(2084)]
        public string TmdbUrl { get; set; }
        [MaxLength(2084), Column("PosterUrl")] 
        public string PosterUrl{ get; set; }
        [MaxLength(2084)]
        public string BackdropUrl { get; set; }
        [MaxLength(24)]
        public string OriginalLanguage { get; set; }
        [Column (TypeName ="DateTime2")]
        public DateTime? ReleaseDate { get; set; }
        public int? RunTime { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal? Price { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? CreateDate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? UpdateDate { get; set; }
        [MaxLength]
        public string CreateBy { get; set; }
        [MaxLength]
        public string UpdateBy { get; set; }


        public ICollection<MovieCrew> MovieCrews { get; set; }
        public ICollection<MovieCast> MovieCasts { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Favorite> Favorites { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
        public ICollection<Trailer> Trailers { get; set; }


    }
}
