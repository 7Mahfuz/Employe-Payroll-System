using Employee_Payroll_Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Payroll_Web.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


    }
}