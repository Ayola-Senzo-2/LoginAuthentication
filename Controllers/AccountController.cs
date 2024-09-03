using Microsoft.AspNetCore.Mvc;

namespace CustomAuth.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
