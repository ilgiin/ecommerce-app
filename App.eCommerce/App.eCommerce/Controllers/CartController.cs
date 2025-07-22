using Microsoft.AspNetCore.Mvc;

namespace App.eCommerce.Controllers
{
    public class CartController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }
         public IActionResult Edit()
        {
            return View();
        }
         public IActionResult RemoveProduct(int id) // sepetten ürün çıkarma
        {
            return View();
        }
         public IActionResult Clear() // sepeti tamamen temizleme
        {
            return View();
        }

    }
}
