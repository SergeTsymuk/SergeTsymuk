using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MvcWebApp.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            List<string> member = new List<string>();
            member.Add("Stepan Razin");
            member.Add("Anka Sidorova");
            member.Add("Vlad Smirnov");
            return View(member);
        }
    }
}
