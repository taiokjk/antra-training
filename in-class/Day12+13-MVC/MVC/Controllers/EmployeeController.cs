using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee() { Name = "Smith", Salary = 5000},
                new Employee() { Name = "David", Salary = 5500},
                new Employee() { Name = "Will", Salary = 6000},
                new Employee() { Name = "Sarah", Salary = 5500},
            };

            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {


            return View();
        }
    }
}
