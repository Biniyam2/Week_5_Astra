using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.GenreRequest
{
    public class UpdateGenreRequest
    {
        public Genre Genre { get; set; }
        public int Id { get; set; }
    }
}
