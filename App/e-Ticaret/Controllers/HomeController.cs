using e_Ticaret.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace App.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }
        [Route("/about-us")]
        public IActionResult AboutUs()
        {
            return Ok();
        }
        public IActionResult Contact()
        {
            return Ok();
        }
        public IActionResult Listing()
        {
            return Ok();
        }

        [Route("/product/{categoryName}-{title}-{id}/details")]
        public IActionResult ProductDetail()
        {
            return Ok();
        }

     

      
    }
}
