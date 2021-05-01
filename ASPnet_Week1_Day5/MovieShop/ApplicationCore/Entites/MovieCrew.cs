using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    public class MovieCrew
    {
        [ForeignKey("Crew"), Key, Required]
        public int CrewId { get; set; }
        public Crew Crew { get; set; }

        [ForeignKey("Movie"), Key, Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [Key, MaxLength(128), Required ]
        public string Department { get; set; }
        [Key, MaxLength(128), Required ]
        public string Job { get; set; }

   
    }
}
