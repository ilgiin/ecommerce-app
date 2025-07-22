using Microsoft.AspNetCore.Mvc;

namespace App.eCommerce.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
        public IActionResult Comment()
        {
            return View();
        }
         public IActionResult AddImage(int productId,IFormFile image) // ürün fotoğrafı ekleme işlemi
        {
            return View();
        }

    }
}
