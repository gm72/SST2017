using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapSite1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult OnCall()
        {
            return View();
        }

        public ActionResult Process(string userid, string password)
        {
            if (userid == "chesapeake" && password == "1223")
                return View("Chesapeake");

            return RedirectToAction("OnCall");
        }
    }
}