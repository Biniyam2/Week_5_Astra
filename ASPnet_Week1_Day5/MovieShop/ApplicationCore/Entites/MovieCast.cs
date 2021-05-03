using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    [Table("MovieCast")]
    public class MovieCast
    {

        [Key, ForeignKey("Movie"),  Required ]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Key, ForeignKey("Cast"),  Required]
        public int CastId { get; set; }
        public Cast Cast { get; set; }

        [Key, MaxLength(450), Required]
        public string Character { get; set; }


    }
}
