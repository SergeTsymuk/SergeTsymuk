using Microsoft.AspNetCore.Mvc;
using Project;
using Project.Interfaces;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public IActionResult Index()
        {
            var allCars = _allCars.GetAllCars;
            return View(allCars);
        }
    }
}
