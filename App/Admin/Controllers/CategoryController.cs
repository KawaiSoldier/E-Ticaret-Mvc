using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Create()
        {
            return Ok();
        }

        [Route("/category/{id}/edit")]
        public IActionResult Edit()
        {
            return Ok();
        }

        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
