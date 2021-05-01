using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entites
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public string Salt { get; set; }
        public string  PhoneNumber { get; set; }
        public byte TowFactorEnabled { get; set; }
        public DateTime LockoutEndDate { get; set; }
        public DateTime LastLodinDateTime { get; set; }
        public byte IsLocked { get; set; }
        public int AccessFaildCount { get; set; }
    }
}
