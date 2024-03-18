using Microsoft.AspNetCore.Mvc;

namespace e_Ticaret.Controllers
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
    }
}
