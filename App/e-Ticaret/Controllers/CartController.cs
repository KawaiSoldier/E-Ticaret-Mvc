using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Controllers
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
    }
}
