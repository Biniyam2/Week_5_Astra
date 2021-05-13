using ApplicationCore.Entites;
using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.RepositoryInterfaces;

namespace Infrastructure.Services
{
    public class PurchaseService :ResponseConverter, IPurchaseService
    {
        private readonly IPurchaseRepository _repository;
        public PurchaseService(IPurchaseRepository repository)
        {
            _repository = repository;
        }

        public async Task<PurchaseResponse> AddAsync(PurchaseRequest purchaseRequest)
        {
            Purchase purchase = new Purchase() { 
               UserId = purchaseRequest.UserId,
               PurchaseNumber = purchaseRequest.PurchaseNumber,
               TotalPrice = purchaseRequest.TotalPrice,
               PurchaseDateTime = purchaseRequest.PurchaseDateTime,
               MovieId =purchaseRequest.MovieId
            };
            var p = await _repository.AddAsync(purchase);
            PurchaseResponse purchaseResponse = new PurchaseResponse()
            {
                UserId = p.UserId,
                PurchaseNumber = p.PurchaseNumber,
                TotalPrice = p.TotalPrice,
                PurchaseDateTime = p.PurchaseDateTime,
                MovieId = p.MovieId
            };
            return purchaseResponse;
        }

        public async void DeleteAsync(PurchaseRequest purchaseRequest)
        {
           
            Purchase purchase = new Purchase()
            {
                UserId = purchaseRequest.UserId,
                PurchaseNumber = purchaseRequest.PurchaseNumber,
                TotalPrice = purchaseRequest.TotalPrice,
                PurchaseDateTime = purchaseRequest.PurchaseDateTime,
                MovieId = purchaseRequest.MovieId
            };
            await _repository.DeleteAsync(purchase);
        }

        public async Task<List<PurchaseResponse>> GetAllPurchasesAsync()
        {
            var p = await _repository.ListAllAsync();
            List<PurchaseResponse> purchases = new List<PurchaseResponse>();
            foreach (var item in p)
            {
                purchases.Add(new PurchaseResponse
                {
                    UserId = item.UserId,
                    PurchaseNumber = item.PurchaseNumber,
                    TotalPrice = item.TotalPrice,
                    PurchaseDateTime = item.PurchaseDateTime,
                    MovieId = item.MovieId,
                    User = UsersResponses(  new List<User> { item.User }),
                    Movie = MoviesResponses(new List<Movie> { item.Movie })
                    
                });
            }
            return purchases;
        }

        public async Task<PurchaseResponse> GetPurchaseByIdAsync(int id)
        {
            var p =await _repository.GetByIdAsync(id);
            PurchaseResponse purchaseResponse = new PurchaseResponse() {
                UserId = p.UserId,
                PurchaseNumber = p.PurchaseNumber,
                TotalPrice = p.TotalPrice,
                PurchaseDateTime = p.PurchaseDateTime,
                MovieId = p.MovieId,
                User = UsersResponses(new List<User> { p.User }),
                Movie = MoviesResponses(new List<Movie> { p.Movie })
            };
            return purchaseResponse;
        }

        public async Task<PurchaseResponse> UpdateAsync(PurchaseRequest purchaseRequest)
        {
            Purchase purchase = new Purchase()
            {
                UserId = purchaseRequest.UserId,
                PurchaseNumber = purchaseRequest.PurchaseNumber,
                TotalPrice = purchaseRequest.TotalPrice,
                PurchaseDateTime = purchaseRequest.PurchaseDateTime,
                MovieId = purchaseRequest.MovieId
            };
            var p = await _repository.UpdateAsync(purchase);
            PurchaseResponse purchaseResponse = new PurchaseResponse()
            {
                UserId = p.UserId,
                PurchaseNumber = p.PurchaseNumber,
                TotalPrice = p.TotalPrice,
                PurchaseDateTime = p.PurchaseDateTime,
                MovieId = p.MovieId
            };
            return purchaseResponse;
        }
    }
}
