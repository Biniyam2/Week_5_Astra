﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entites;
using Infrastructure.Data;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class CrewRepository : EfRepository<Crew>, ICrewRepository
    {
        public CrewRepository(MovieShopDbContext dbContext) : base(dbContext)
        {

        }
    }
}
