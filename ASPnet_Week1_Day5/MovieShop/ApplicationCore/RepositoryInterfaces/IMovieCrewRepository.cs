using ApplicationCore.Entites;
using ApplicationCore.RepsoitoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieCrewRepository : IAsyncRepository<MovieCrew>
    {
    }
}
