using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eSankalpMed.Models;

namespace eSankalpMed.Controllers
{
    public class AdminListController : Controller
    {
        // GET: AdminList
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetPrescriptionList()
        {
            try
            {
                return Json(new { model = new PrescriptionModel().GetPrescriptionList() }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { models = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}