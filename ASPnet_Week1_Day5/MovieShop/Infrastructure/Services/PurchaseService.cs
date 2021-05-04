using ApplicationCore.Entites;
using ApplicationCore.Models.Response.PurchaseResponse;
using ApplicationCore.Models.Resquest.PurchaseRequest;
using ApplicationCore.RepsoitoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IRepository<Purchase> _repository;
        public PurchaseService(IRepository<Purchase> repository)
        {
            _repository = repository;
        }

        public DeletePurchaseResponse Delete(DeletePurchaseRequest deletePurchaseRequest)
        {
            var p = _repository.GetById(deletePurchaseRequest.Id);
            _repository.Delete(p);
            return new DeletePurchaseResponse();
        }

        public GetPurchaseResponse GetPurchase(GetPurchaseRequest getPurchaseRequest)
        {
            GetPurchaseResponse getPurchaseResponse = new GetPurchaseResponse();
            getPurchaseResponse.Purchase = _repository.GetById(getPurchaseRequest.Id);
            return new GetPurchaseResponse();
        }

        public FetchPurchaseResponse GetPurchases(FetchPurchaseRequest fetchPurchaseRequest)
        {
            throw new NotImplementedException();
        }

        public CreatePurchaseResponse Insert(CreatePurchaseRequest createPurchaseRequest)
        {
            _repository.Insert(createPurchaseRequest.Purchase);
            return new CreatePurchaseResponse();
        }

        public UpdatePurchaseResponse Update(UpdatePurchaseRequest updatePurchaseRequest)
        {
            var p = _repository.GetById(updatePurchaseRequest.Id);
            _repository.Update(p);
            return new UpdatePurchaseResponse();
        }
    }
}
