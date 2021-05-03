using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.CrewRequest
{
    public class UpdateCrewRequest
    {
        public Crew Crew { get; set; }
        public int Id { get; set; }
    }
}
