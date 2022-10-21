using Ecommerce_Project.DataAccess;
using Ecommerce_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController : Controller
    {
        private readonly PagesContext context;

        public PagesController(PagesContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            IQueryable<Page> pages = from p in context.Pages orderby p.Sorting select p;
            List<Page> pagesList = await pages.ToListAsync();
            return View(pagesList);
        }
    }
}
