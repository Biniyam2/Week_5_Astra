﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    [Table("MovieGenre")]
    public class MovieGenre
    {

        [ForeignKey("Movie"), Key, Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("Genre"), Key, Required]
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}
