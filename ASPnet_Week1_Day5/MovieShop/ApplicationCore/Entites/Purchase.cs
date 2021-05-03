using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    [Table("Purchase")]
    public class Purchase
    {
        [Key, Required]
        public int Id { get; set; }
        [ForeignKey("User"),Required]
        public int UserId { get; set; }
        public User User { get; set; }
        [Column(TypeName = "Uniqueidentifier"), Required]
        public Guid PurchaseNumber { get; set; }
        [Column(TypeName = "decimal(18,2)"), Required]
        public decimal TotalPrice { get; set; }
        [Column(TypeName = "DateTime2"), Required]
        public DateTime PurchaseDateTime { get; set; }
        [ForeignKey("Movie"), Required]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
      
       
       
    }
}
