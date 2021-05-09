using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class GenreResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
    }
}
