using ApplicationCore.Entites;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IReviewRepository _repository;
        public ReviewService(IReviewRepository repository)
        {
            _repository = repository;
        }

        public async void AddAsync()
        {
            var rev = new ReviewRequest();
            Review review = new Review() {
            MovieId = rev.MovieId,
            UserId = rev.UserId,
            Rating = rev.Rating,
            ReviewText = rev.ReviewText
            };
            await _repository.AddAsync(review);
        }

        public async void DeleteAsync()
        {
            var rev = new ReviewRequest();
            Review review = new Review()
            {
                MovieId = rev.MovieId,
                UserId = rev.UserId,
                Rating = rev.Rating,
                ReviewText = rev.ReviewText
            };
            await _repository.DeleteAsync(review);
        }

        public async Task<List<ReviewResponse>> GetAllReviewsAsync()
        {
            var rev =await _repository.ListAllAsync();
            List<ReviewResponse> reviewResponses = new List<ReviewResponse>();
            foreach (var item in rev)
            {
                reviewResponses.Add(new ReviewResponse {
                    MovieId = item.MovieId,
                    UserId = item.UserId,
                    Rating = item.Rating,
                    ReviewText = item.ReviewText
                });
            }
            return reviewResponses;
        }

        public async Task<ReviewResponse> GetReviewByIdAsync(int id)
        {
            var rev = await _repository.GetByIdAsync(id);
            ReviewResponse reviewResponse = new ReviewResponse() {
                MovieId = rev.MovieId,
                UserId = rev.UserId,
                Rating = rev.Rating,
                ReviewText = rev.ReviewText
            };
            return reviewResponse;
        }

        public async void UpdateAsync()
        {
            var rev = new ReviewRequest();
            Review review = new Review()
            {
                MovieId = rev.MovieId,
                UserId = rev.UserId,
                Rating = rev.Rating,
                ReviewText = rev.ReviewText
            };
            await _repository.UpdateAsync(review);
        }
    }
}
