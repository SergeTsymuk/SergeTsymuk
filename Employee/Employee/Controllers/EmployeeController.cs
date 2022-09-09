using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        public Models.MEmployee _employee;
        public IActionResult Index()
        {
            //return View();
            List<MEmployee> employee = new List<MEmployee>{
                new MEmployee() { Id = 1, FirstName = "John", LastName = "Irvin" } ,
                new MEmployee() { Id = 2, FirstName = "Steve",  LastName = "Stivenson" } ,
                new MEmployee() { Id = 3, FirstName = "Bill",  LastName = "Brown" } ,
                new MEmployee() { Id = 4, FirstName = "Ram" , LastName = "Richardson" } ,
                new MEmployee() { Id = 5, FirstName = "Ron" , LastName = "Piterson" } ,
                new MEmployee() { Id = 4, FirstName = "Chris" , LastName = "Tven" } ,
                new MEmployee() { Id = 4, FirstName = "Rob" , LastName = "Ford" } };
            ViewBag.MyBag = "Employee Form";
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit()
        {
            // update student to the database

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            // delete student from the database whose id matches with specified id

            return RedirectToAction("Index");
        }
    }
}
