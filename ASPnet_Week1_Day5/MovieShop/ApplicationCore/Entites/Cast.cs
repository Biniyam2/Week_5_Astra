using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    public class Cast
    {
        [Key, Required]
        public int Id { get; set; }
        [MaxLength(128)]
        public string Name { get; set; }
        [MaxLength]
        public string Gender { get; set; }
        [MaxLength]
        public string TmbdUrl { get; set; }
        [MaxLength(2084)]
        public string ProfilePath { get; set; }

        public ICollection<MovieCast> MovieCasts { get; set; }
    }
}
