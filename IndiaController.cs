using MVC_IBMJune2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_IBMJune2023.Controllers
{
    public class IndiaController : Controller
    {
        // GET: India
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee1 emp)
        {
            return View();
        }


        public ActionResult delhi()
        {
            return View();
        }


        public ActionResult htmlhelpersdemo()
        {
            return View();  
        }

        public ActionResult stronglytypedhtmlhelpersdemo()
        {
            return View();
        }
    }
}