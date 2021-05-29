using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eSankalpMed.Data;

namespace eSankalpMed.Models
{
    public class AdminListModel
    {
        public int Customer_Id { get; set; }
        public string Patient_Name { get; set; }
        public string Photo { get; set; }
        public System.DateTime Uploaded_Date { get; set; }
        public string Uploaded_DateString { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Delivery_date { get; set; }
        
        public List<PrescriptionModel> GetPrescriptionList()
        {
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            List<PrescriptionModel> lstPrescription = new List<PrescriptionModel>();
            var PrescriptionList = db.tbl_Prescription.ToList();
            if (PrescriptionList != null)
            {
                foreach (var Prescription in PrescriptionList)
                {
                    lstPrescription.Add(new PrescriptionModel()
                    {
                        Customer_Id = Prescription.Customer_Id,
                        Patient_Name = Prescription.Patient_Name,
                        Photo = Prescription.Photo,
                        Uploaded_DateString = Prescription.Uploaded_Date.ToString("dd/MM/yyyy"),
                        Status=Prescription.Status,
                        Delivery_date = Prescription.Delivery_date,

                    });
                }
            }
            return lstPrescription;
        }
    }
}