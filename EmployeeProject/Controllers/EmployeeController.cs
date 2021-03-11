using EmployeeProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeProject.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService service = new EmployeeService();

        [Route("")]
        [Route("employees/index")]
        public IActionResult Index()
        {
            var employs = service.GetAllEmployees();
            return View(employs);
        }

        
        [Route("CreateEmployees")]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Route("CreateEmployees")]
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }
            service.AddEmployee(employee);
            return RedirectToAction(nameof(Index));
        }

        [Route("details/{id}")]
        public IActionResult Detail(int id)
        {
            var employ = service.GetEmployeeById(id);
            return View(employ);
        }
    }
}
