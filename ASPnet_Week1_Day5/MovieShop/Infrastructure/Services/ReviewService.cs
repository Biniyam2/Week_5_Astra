using ApplicationCore.Entites;
using ApplicationCore.Models.Response.ReviewResponse;
using ApplicationCore.Models.Resquest.ReviewRequest;
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
        private readonly IRepository<Review> _repository;
        public ReviewService(IRepository<Review> repository)
        {
            _repository = repository;
        }
        public DeleteReviewResponse Delete(DeleteReviewRequest deleteReviewRequest)
        {
            var r = _repository.GetById(deleteReviewRequest.Id);
            _repository.Delete(r);
            return new DeleteReviewResponse();
        }

        public GetReviewResponse GetReview(GetReviewRequest getReviewRequest)
        {
            GetReviewResponse getReviewResponse = new GetReviewResponse();
            getReviewResponse.Review = _repository.GetById(getReviewRequest.Id);
            return new GetReviewResponse();
        }

        public FetchReviewResponse GetReviews(FetchReviewRequest fetchReviewRequest)
        {
            throw new NotImplementedException();
        }

        public CreateReviewResponse Insert(CreateReviewRequest createReviewRequest)
        {
            _repository.Insert(createReviewRequest.Review);
            return new CreateReviewResponse();
        }

        public UpdateReviewResponse Update(UpdateReviewRequest updateReviewRequest)
        {
            var r = _repository.GetById(updateReviewRequest.Id);
            _repository.Update(r);
            return new UpdateReviewResponse();
        }
    }
}
