﻿using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICastService
    {
        public Task<List<CastResponse>> GetAllCastsAsync();
        public Task<CastResponse> GetCastByIdAsync(int id);
        public void AddAsync(CastRequest castRequest);
        public void DeleteAsync(CastRequest castRequest);
        public void UpdateAsync(CastRequest castRequest);
    }
}
