using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutofactDI.Models;

namespace AutofactDI.Controllers
{
    public class HomeController : Controller
    {

        private IPerson personRepo;

        public HomeController(IPerson person)
        {
            this.personRepo = person;
        }

        public ActionResult Index()
        {
            //IPerson person= new PersonRepository();

            var data = personRepo.GetAllPerson();
            ViewBag.somePerson = data;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}