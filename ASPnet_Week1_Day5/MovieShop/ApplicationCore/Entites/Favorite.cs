using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    public class Favorite
    {
        [Key, Required]
        public int Id { get; set; }

        [ForeignKey("Movie"), Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("User"), Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
