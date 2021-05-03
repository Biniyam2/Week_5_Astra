using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.FavoriteRequest
{
    public class UpdateFavoriteRequest
    {
        public Favorite Favorite { get; set; }
        public int Id { get; set; }
    }
}
