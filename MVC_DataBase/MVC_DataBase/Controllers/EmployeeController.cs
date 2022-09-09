using Microsoft.AspNetCore.Mvc;
using MVC_DataBase.DATA;
using System.Collections.Generic;

namespace MVC_DataBase.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private IEnumerable<Employee> employee;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Details(int id)
        {
            IEmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employee.Find(id);
            return View(employee);
        }

        public IActionResult Index()
        {
            employee = _employeeRepository.GetAll();

            return View(employee);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Employee employee)
        {
            _employeeRepository.CreateNewEmployee(employee);
            _employeeRepository.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            IEmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employee.Find(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employeeRepository.EditEmployee(employee);
            _employeeRepository.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            IEmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.Employee.Find(id);
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Employee employee)
        {
            _employeeRepository.DeleteEmployee(employee);
            _employeeRepository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
