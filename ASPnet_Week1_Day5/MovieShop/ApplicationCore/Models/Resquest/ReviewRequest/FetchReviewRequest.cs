using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.ReviewRequest
{
    public  class FetchReviewRequest
    {
        public int PageNumber { get; set; }
        public int ReviewPerPage { get; set; }
    }
}
