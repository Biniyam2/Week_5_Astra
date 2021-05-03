using ApplicationCore.Models.Response.PurchaseResponse;
using ApplicationCore.Models.Resquest.PurchaseRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IPurchaseService
    {
        public CreatePurchaseResponse Insert(CreatePurchaseRequest createPurchaseRequest);
        public DeletePurchaseResponse Delete(DeletePurchaseRequest deletePurchaseRequest);
        public UpdatePurchaseResponse Update(UpdatePurchaseRequest updatePurchaseRequest);
        public GetPurchaseResponse GetPurchase(GetPurchaseRequest getPurchaseRequest);
        public FetchPurchaseResponse GetPurchases(FetchPurchaseRequest fetchPurchaseRequest);
    }
}
