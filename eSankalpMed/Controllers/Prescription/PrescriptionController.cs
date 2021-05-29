using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eSankalpMed.Models;

namespace eSankalpMed.Controllers.Prescription
{
    public class PrescriptionController : Controller
    {
        // GET: Prescription
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SavePrescription(PrescriptionModel model)
        {
            try
            {
                HttpPostedFileBase fb = null;
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    fb = Request.Files[i];

                }

                return Json(new { models = new PrescriptionModel().SavePrescription(fb, model) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { models = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}