using Microsoft.AspNetCore.Mvc;

namespace App.eCommerce.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult MyOrders()
        {
            return View();
        }
        public IActionResult MyProducts()
        {
            return View();
        }
        public IActionResult RequestSeller() //satıcı olma isteği
        { 
            return View();
        }

    }
}
