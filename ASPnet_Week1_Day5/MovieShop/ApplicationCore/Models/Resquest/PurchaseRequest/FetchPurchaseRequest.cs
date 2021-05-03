using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.PurchaseRequest
{
    public class FetchPurchaseRequest
    {
        public int PageNumber { get; set; }
        public int PurchasePerPage { get; set; }
    }
}
