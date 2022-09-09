using Microsoft.AspNetCore.Mvc;

namespace MvcWebApp.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
