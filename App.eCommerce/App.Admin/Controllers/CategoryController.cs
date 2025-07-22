using Microsoft.AspNetCore.Mvc;

namespace App.Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [Route("/category/{id}/edit")]
         public IActionResult Edit()
        {
            return View();
        }
         public IActionResult Delete()
        {
            return View();
        }

    }
}
