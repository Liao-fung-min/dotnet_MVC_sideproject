using ProductSideproject.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProductSideproject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employeelist = new List<Employee>();
            Employee employee1 = new Employee
            {
                ID = 1,
                Name = "Alex",
                Salary = 4000
            };
            employeelist.Add(employee1);
            Employee employee2 = new Employee
            {
                ID = 2,
                Name = "Liao",
                Salary = 4399
            };
            employeelist.Add(employee2);
            return View(employeelist);
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        public ActionResult UpdateEmployee()
        {
            return View();
        }
    }
}