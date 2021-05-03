using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.PurchaseRequest
{
    public class UpdatePurchaseRequest
    {
        public Purchase Purchase { get; set; }
        public int Id { get; set; }
    }
}
