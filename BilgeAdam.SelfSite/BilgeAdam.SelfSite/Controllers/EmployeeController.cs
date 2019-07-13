using BilgeAdam.SelfSite.Contracts;
using BilgeAdam.SelfSite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BilgeAdam.SelfSite.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService service;

        public EmployeeController(IEmployeeService service, IHttpContextAccessor httpContext)
        {
            //constructor çalışmadan önce depended nesneler ServiceCollection'a sorulur. Registration varsa instance alınır
            //Bkz. Startup ConfiureServices
            this.service = service;
            var service2 = httpContext.HttpContext.RequestServices.GetService(typeof(IEmployeeService));
            var service3 = httpContext.HttpContext.RequestServices.GetService(typeof(IEmployeeService));
            var service4 = httpContext.HttpContext.RequestServices.GetService(typeof(IEmployeeService));

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