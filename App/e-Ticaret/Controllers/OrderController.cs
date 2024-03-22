using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Controllers
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
            return Ok();
        }
    }
}
