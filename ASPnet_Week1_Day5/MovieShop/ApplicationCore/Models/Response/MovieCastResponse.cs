using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class MovieCastRequest
    {
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Character { get; set; }
    }
}
