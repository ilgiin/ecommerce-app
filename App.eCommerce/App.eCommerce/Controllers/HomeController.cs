using App.eCommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.eCommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/about-us")]
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Listing()
        {
            return View();
        }
        public IActionResult Search() //�r�n arama �zelli�i
        {
            return View();
        }
        public IActionResult Filter() //�r�n filtreleme �zelli�i
        {
            return View();
        }

        [Route("/product/{categoryName}-{title}-{id}/details")]
        public IActionResult ProductDetail()
        {
            return View();
        }

    }
}
