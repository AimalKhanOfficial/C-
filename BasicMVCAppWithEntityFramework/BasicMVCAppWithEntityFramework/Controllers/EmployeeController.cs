using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicMVCAppWithEntityFramework.DAL;
using BasicMVCAppWithEntityFramework.Models;

namespace BasicMVCAppWithEntityFramework.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employees employeesDal = new Employees();
            return View(employeesDal.GetEmployees());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                var employeeDal = new Employees();

                if (!ModelState.IsValid)
                {
                    return View();
                }

                if (employeeDal.AddNewEmployee(employee))
                    return RedirectToAction("Index");

                TempData["employee"] = employee;

                ModelState.AddModelError("Name", "Cannot add a new employee right now, try again!");
                return View(employee);

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Name", "Something went wrong, please try again!");
                return View(employee);
            }
        }
    }
}