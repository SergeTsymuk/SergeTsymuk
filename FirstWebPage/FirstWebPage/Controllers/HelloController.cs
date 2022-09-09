using Microsoft.AspNetCore.Mvc;

namespace FirstWebPage.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
