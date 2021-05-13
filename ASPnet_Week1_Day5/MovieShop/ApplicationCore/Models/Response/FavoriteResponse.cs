using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class FavoriteResponse
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public MovieResponse Movie { get; set; }
        public int UserId { get; set; }
        public UserResponse User { get; set; }
    }
}
