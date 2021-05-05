using ApplicationCore.Models.Response;
using ApplicationCore.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IPurchaseService
    {
        public Task<List<PurchaseResponse>> GetAllPurchasesAsync();
        public Task<PurchaseResponse> GetPurchaseByIdAsync(int id);
        public void AddAsync();
        public void DeleteAsync();
        public void UpdateAsync();
    }
}
