using Microsoft.AspNetCore.Mvc;

namespace HeroBiz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
