using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.MVC.Filters
{
    public class MovieShopHeaderFilter : IActionFilter
    {
        private readonly ICurrentUserService _currentUserService;
        public MovieShopHeaderFilter(ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService; 
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            int? num = _currentUserService.UserId;
            string email = _currentUserService.Email;
            string fullName = _currentUserService.FullName;
            var isAuthenticated = _currentUserService.IsAuthenticated;

            if (!isAuthenticated)
            {
                throw new Exception("Not Authenticated");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

     
    }
}
