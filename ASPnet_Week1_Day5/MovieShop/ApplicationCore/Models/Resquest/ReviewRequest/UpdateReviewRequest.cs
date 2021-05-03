
using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.ReviewRequest
{
    public class UpdateReviewRequest
    {
        public Review Review { get; set; }
        public int Id { get; set; }
    }
}
