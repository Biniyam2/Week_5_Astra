using ApplicationCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public string PhoneNumber { get; set; }
        public byte? TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDate { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public byte? IsLocked { get; set; }
        public int? AccessFailedCount { get; set; }

        public IEnumerable<RoleResponse> Roles { get; set; }

        public IEnumerable<FavoriteResponse> Favorites { get; set; }
        public IEnumerable<PurchaseResponse> Purchases { get; set; }
        public IEnumerable<UserRoleResponse> UserRoles { get; set; }
        public IEnumerable<ReviewResponse> Reviews { get; set; }

        //public IEnumerable<Favorite> Favorites { get; set; }
        //public IEnumerable<Purchase> Purchases { get; set; }
        //public IEnumerable<UserRole> UserRoles { get; set; }
        //public IEnumerable<Review> Reviews { get; set; }
    }
}
