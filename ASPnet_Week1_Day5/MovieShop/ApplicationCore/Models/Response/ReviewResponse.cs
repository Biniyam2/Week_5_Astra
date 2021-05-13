using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class ReviewResponse
    {
        public int MovieId { get; set; }
        public MovieResponse Movie { get; set; }
        public int UserId { get; set; }
        public UserResponse User { get; set; }
        public decimal Rating { get; set; }
        public string ReviewText { get; set; }
    }
}
