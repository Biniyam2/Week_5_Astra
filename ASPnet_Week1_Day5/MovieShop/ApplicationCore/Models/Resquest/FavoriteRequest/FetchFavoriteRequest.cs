using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Resquest.FavoriteRequest
{
    public class FetchFavoriteRequest
    {
        public int PageNumber { get; set; }
        public int FavoritesPerPage { get; set; }
    }
}
