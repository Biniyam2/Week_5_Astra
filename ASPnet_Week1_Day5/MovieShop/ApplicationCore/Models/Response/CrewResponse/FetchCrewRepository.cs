using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;

namespace ApplicationCore.Models.Response.CrewResponse
{
    public class FetchCrewRepository 
    {
        public int CrewsPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<Crew> Crew { get; set; }
    }
}
