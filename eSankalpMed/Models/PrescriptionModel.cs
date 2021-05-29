using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using eSankalpMed.Data;


namespace eSankalpMed.Models
{
    public class PrescriptionModel
    {
        public int Customer_Id { get; set; }
        public string Patient_Name { get; set; }
        public string Photo { get; set; }
        public System.DateTime Uploaded_Date { get; set; }
        public string Uploaded_DateString { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Delivery_date { get; set; }
      public string Delivery_dateString { get; set; }
        public string SavePrescription(HttpPostedFileBase fb, PrescriptionModel model)
        {
            string message = "";
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            string filePath = "";
            string fileName = "";
            string sysFileName = "";


            if (fb != null && fb.ContentLength > 0)
            {
                filePath = HttpContext.Current.Server.MapPath("~/Content/images/");
                DirectoryInfo di = new DirectoryInfo(filePath);
                if (!di.Exists)
                {
                    di.Create();
                }
                fileName = fb.FileName;
                sysFileName = DateTime.Now.ToFileTime().ToString() + Path.GetExtension(fb.FileName);
                fb.SaveAs(filePath + "//" + sysFileName);
                if (!string.IsNullOrWhiteSpace(fb.FileName))
                {
                    string afileName = HttpContext.Current.Server.MapPath("~/Content/images/") + "/" + sysFileName;

                }
            }
            var savePrescription = new tbl_Prescription()
            {

                Patient_Name = model.Patient_Name,
                Photo = sysFileName,
                Uploaded_Date = model.Uploaded_Date,
                Status=model.Status,
                Delivery_date=model.Delivery_date,
            };
            db.tbl_Prescription.Add(savePrescription);
            db.SaveChanges();
            message = "Registration Succesfully";
            return message;
        }
        public List<PrescriptionModel> GetPrescriptionList()
        {
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            List<PrescriptionModel> lstPrescription = new List<PrescriptionModel>();
            var PrescriptionList = db.tbl_Prescription.ToList();
            if (PrescriptionList != null)
            {
               
                foreach (var Prescription in PrescriptionList)
                {
                    if (Prescription.Delivery_date != null)
                    {
                        Delivery_dateString = Prescription.Delivery_date.Value.ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        Delivery_dateString = "";
                    }
                    lstPrescription.Add(new PrescriptionModel()
                    {
                        Customer_Id = Prescription.Customer_Id,
                        Patient_Name = Prescription.Patient_Name,
                        Photo = Prescription.Photo,
                        Uploaded_DateString = Prescription.Uploaded_Date.ToString("dd/MM/yyyy"),
                        Status = Prescription.Status,
                        Delivery_dateString= Delivery_dateString ,
                    });
                }
            }
            return lstPrescription;
        }
    }
}