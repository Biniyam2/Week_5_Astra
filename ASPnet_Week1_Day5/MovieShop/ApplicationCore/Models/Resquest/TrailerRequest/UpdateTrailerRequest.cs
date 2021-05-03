using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.TrailerRequest
{
    public  class UpdateTrailerRequest
    {
        public Trailer Trailer { get; set; }
        public int Id { get; set; }
    }
}
