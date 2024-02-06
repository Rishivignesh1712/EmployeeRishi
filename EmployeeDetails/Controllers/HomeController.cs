using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeDetails.Controllers
{
    public class HomeController : Controller
    {
        private List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Rishi", Salary = 90000},
            new Employee { Name = "prabhu", Salary = 50000},
            new Employee { Name = "vadivel", Salary = 40000},
            new Employee { Name = "deva", Salary = 60000},
            new Employee { Name = "bhu", Salary = 80000},
            new Employee { Name = "varadha", Salary = 80000},
            new Employee { Name = "parthiban", Salary = 90000},
            new Employee { Name = "Subramani", Salary = 40000},
            new Employee { Name = "Harold das", Salary = 50000},
            new Employee { Name = "Elisa", Salary = 60000}
        };
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(int inputSalary)
        {
            var filteredEmployees = employees.FindAll(e => e.Salary > inputSalary);
            return View(filteredEmployees);
        }
    }
}
