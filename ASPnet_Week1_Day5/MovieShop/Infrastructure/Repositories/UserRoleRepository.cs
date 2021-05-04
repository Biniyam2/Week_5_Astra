﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Entites;
using Infrastructure.Data;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class UserRoleRepository : EfRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}
