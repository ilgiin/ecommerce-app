using Microsoft.AspNetCore.Mvc;

namespace App.Admin.Controllers
{
    public class UserController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
         public IActionResult Approve()
        {
            return View();
        }
         public IActionResult Delete(int id)
        {
            return View();
        }

    }
}
