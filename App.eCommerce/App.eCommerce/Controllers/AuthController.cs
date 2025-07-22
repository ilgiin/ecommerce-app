using Microsoft.AspNetCore.Mvc;

namespace App.eCommerce.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return View();
        }
        public IActionResult ResetPassword() //maill üzerinden şifre sıfırlama
        {
            return View();
        }
        public IActionResult ResendComfirmation() //maill'e tekrar onay linki gönderme
        {
            return View();
        }

    }
}
