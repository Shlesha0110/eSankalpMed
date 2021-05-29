using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eSankalpMed.Data;

namespace eSankalpMed.Models
{
    public class RegistrationModel
    {
        public long CustId { get; set; }
        public string CustName { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Details { get; set; }
        public System.DateTime Date { get; set; }
        public int Status { get; set; }
        public string GST { get; set; }
        public string PAN { get; set; }
        public string Password { get; set; }

        public string SaveRegistration(RegistrationModel model)
        {
            string Message = "successfull";
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            var saveRegistration = new tbl_Customer()
            {
                CustId = model.CustId,
                CustName = model.CustName,
                Address = model.Address,
                Mobile = model.Mobile,
                Email = model.Email,
                Details = model.Details,
                Date = model.Date,
                Status = model.Status,
                GST = model.GST,
                PAN = model.PAN,
                Password=model.Password
               


            };
            db.tbl_Customer.Add(saveRegistration);
            db.SaveChanges();
            return Message;
        }
    }
}