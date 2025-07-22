using Microsoft.AspNetCore.Mvc;

namespace App.eCommerce.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [Route("/order/{id}/details")]
        public IActionResult Details()
        {
            return View();
        }
         public IActionResult OrderStatus(int orderId) // sipariş (kargo) durumu 
        {
            return View();
        }

    }
}
