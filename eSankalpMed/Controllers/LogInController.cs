using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eSankalpMed.Data;
using eSankalpMed.Models;

namespace eSankalpMed.Controllers
{
    public class LogInController : Controller
    {
        // GET: LogIn
        public ActionResult Index()
        {
            return View();
        }
        public esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();

        public ActionResult LoginIn(RegistrationModel model)
        {
            var user = db.tbl_Customer.Where(m => m.CustName == model.CustName && m.Password == model.Password).FirstOrDefault();
            if (ModelState.IsValid)
            {
                if (user != null)
                {
                    Session["CustId"] = user.CustId.ToString();
                    Session["CustName"] = user.CustName.ToString();

                    //return RedirectToAction("Offer");
                    return View("..\\FirstPage\\Dashboard");

                }
                else
                {
                    ModelState.AddModelError("", "Invalid CustName or password.");

                }

            }
            return View("..\\Home\\Index", model);
        }

    }
}