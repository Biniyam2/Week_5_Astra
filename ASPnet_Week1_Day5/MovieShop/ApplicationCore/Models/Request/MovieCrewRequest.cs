using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Request
{
    public class MovieCrewRequest
    {
        public int CrewId { get; set; }
        public int MovieId { get; set; }
        public string Department { get; set; }
        public string Job { get; set; }
    }
}
