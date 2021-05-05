﻿using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IReviewService
    {
        public Task<List<ReviewResponse>> GetAllReviewsAsync();
        public Task<ReviewResponse> GetReviewByIdAsync(int id);
        public void AddAsync();
        public void DeleteAsync();
        public void UpdateAsync();
    }
}
