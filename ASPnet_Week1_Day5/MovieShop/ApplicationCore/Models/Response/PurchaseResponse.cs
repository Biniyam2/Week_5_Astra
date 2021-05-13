using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class PurchaseResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Guid PurchaseNumber { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public int MovieId { get; set; }

        public IEnumerable<UserResponse> User { get; set; }
        public  IEnumerable<MovieResponse> Movie { get; set; }
        //public UserResponse UserResponse { get; set; }
        //public MovieResponse  MovieResponse { get; set; }
    }
}
