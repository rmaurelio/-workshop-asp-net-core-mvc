using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellervice;

        public SellersController(SellerService sellerService)
        {
            _sellervice = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellervice.FindAll();
            return View(list);
        }
    }
}
