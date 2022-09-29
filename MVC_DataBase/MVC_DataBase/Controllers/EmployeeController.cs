using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MVC_DataBase.DATA;
using X.PagedList.Mvc;
using X.PagedList;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_DataBase.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private IEnumerable<Employee> employees;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult Details(int id)
        {
            Employee employee = _employeeRepository.GetById(id);
            return View(employee);
        }

        public IActionResult Index(string sortOrder, string currentFilter ,string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.FirstNameSortParm = String.IsNullOrEmpty(sortOrder) ? "FirstName_desc" : "";
            ViewBag.LastNameSortParam = sortOrder == "LastName" ? "LastName_Asc" : "LastName";
            ViewBag.DepartmentSortParam = sortOrder == "Department" ? "Department_Asc" : "Department";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            employees = _employeeRepository.GetAll();
            if (!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(s => s.FirstName.Contains(searchString) || s.LastName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "FirstName_desc":
                    employees = employees.OrderByDescending(s => s.FirstName);
                    break;
                case "LastName":
                    employees = employees.OrderBy(s => s.LastName);
                    break;
                case "LastName_desc":
                    employees = employees.OrderByDescending(s => s.LastName);
                    break;
                case "Department":
                    employees = employees.OrderBy(s => s.Department);
                    break;
                case "Department_desc":
                    employees = employees.OrderByDescending(s => s.Department);
                    break ;
                default:
                    employees = employees.OrderBy(s => s.FirstName);
                    break;
            }
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(employees.ToPagedList(page ?? 1, pageSize));
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
            if (ModelState.IsValid)
            {
                _employeeRepository.Add(employee);
                return RedirectToAction("Index");
            }
            else 
            {
                return View(employee);
            }
            
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee employee = _employeeRepository.GetById(id);
            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            _employeeRepository.Update(employee);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee employee = _employeeRepository.GetById(id);
            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Employee employee)
        {
            _employeeRepository.Delete(employee);
            return RedirectToAction("Index");
        }
    }
}
