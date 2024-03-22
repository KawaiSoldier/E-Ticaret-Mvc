using Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Admin.Controllers
{
    public class HomeController : Controller
    {
 
        public IActionResult Index()
        {
            return View();
        }


    }
}
