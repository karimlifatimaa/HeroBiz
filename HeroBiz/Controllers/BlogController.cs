using Microsoft.AspNetCore.Mvc;

namespace HeroBiz.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
