using BilgeAdam.SelfSite.Contracts;
using BilgeAdam.SelfSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BilgeAdam.SelfSite.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            //constructor çalışmadan önce depended nesneler ServiceCollection'a sorulur. Registration varsa instance alınır
            //Bkz. Startup ConfiureServices
            this.service = service;
        }
        public IActionResult Index()
        {
            var employees = service.GetEmployees().Select(e => new EmployeeViewModel
            {
                Id = e.Id,
                FullName = e.FullName,
                City = e.City,
                Country = e.Country,
                HireDate = e.HireDate
            }).ToList();

            return View(employees);
        }
    }
}