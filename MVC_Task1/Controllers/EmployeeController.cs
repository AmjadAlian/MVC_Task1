using Microsoft.AspNetCore.Mvc;
using MVC_Task1.Data;

namespace MVC_Task1.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Employees = context.employees.ToList();
            return View("Index",Employees);
        }
    }
}
