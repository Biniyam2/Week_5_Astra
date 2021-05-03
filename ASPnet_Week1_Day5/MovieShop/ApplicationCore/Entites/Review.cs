using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    [Table("Review")]
    public class Review
    {
        [ForeignKey("Movie"), Key, Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("User"),Key, Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Column (TypeName = "decimal(3,2)"), Required]
        public decimal Rating { get; set; }
        [MaxLength]
        public string ReviewText { get; set; }

   
      
    }
}
