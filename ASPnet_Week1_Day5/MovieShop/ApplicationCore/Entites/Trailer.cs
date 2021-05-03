using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    [Table("Trailer")]
    public class Trailer
    {
        [Key, Required]
        public int Id { get; set; }

        [ForeignKey("Movie"),Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [MaxLength(2084)]
        public  string TrailerUrl { get; set; }
        [MaxLength(2084)]
        public string Name { get; set; }

    }
}
