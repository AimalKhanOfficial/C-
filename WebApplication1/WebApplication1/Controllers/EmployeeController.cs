using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Web.WebPages;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var genderList = new List<ListItem>();
            genderList.Add(new ListItem()
            {
                Text = "Male", Value = "1"
            });
            genderList.Add(new ListItem()
            {
                Text = "Female",
                Value = "2"
            });
            ViewBag.Gender = genderList;
            return View();
        }

        public ActionResult ListEmployees()
        {
            ViewData["viewD"] = "Aimal Khan";
            ViewBag.viewB = "Aimal Khan";

            var list = new List<ViewModelLogin>
            {
                new ViewModelLogin()
                {
                    Username = "Aimal",
                    Password = "123"
                }
            };
            return View(list);
        }



        [HttpPost]
        [Attr]
        public ActionResult Index(ViewModelLogin vmLogin)
        {

            bool testAjax = Request.IsAjaxRequest();

            if (!ModelState.IsValid)
            {
                return View(vmLogin);
            }
            else
            {
                return View();
            }
        }
    }
}