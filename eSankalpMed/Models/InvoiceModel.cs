using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eSankalpMed.Data;

namespace eSankalpMed.Models
{
    public class InvoiceModel
    {
        public Nullable<long> CustId { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public decimal TotalAmt { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public string InvoiceDateString { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public string Time { get; set; }
        public string PayMode { get; set; }
        public string Paid { get; set; }
        public string Note { get; set; }
        public Nullable<decimal> Advance { get; set; }
        public Nullable<decimal> Point { get; set; }
        public string Person { get; set; }
        public Nullable<int> InvoiceId { get; set; }
        public Nullable<decimal> SGST { get; set; }
        public Nullable<decimal> CGST { get; set; }
        public Nullable<decimal> IGST { get; set; }
        public long AutoInvoiceID { get; set; }

        public string SaveInvoice(InvoiceModel model)
        {
            string Message = "";
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            var saveInvoice = new tbl_Invoice()
            {

                CustId = model.CustId,
                Amount = model.Amount,
                Discount = model.Discount,
                TotalAmt = model.TotalAmt,
                InvoiceDate = model.InvoiceDate,
                Vat = model.Vat,
                Time = model.Time,
                PayMode = model.PayMode,
                Paid = model.Paid,
                Note = model.Note,
                Advance = model.Advance,
                Point = model.Point,
                Person = model.Person,
                InvoiceId = model.InvoiceId,
                SGST = model.SGST,
                CGST = model.CGST,
                IGST = model.IGST,
                AutoInvoiceID = model.AutoInvoiceID

            };
            db.tbl_Invoice.Add(saveInvoice);
            db.SaveChanges();
            return Message;
        }


        public List<InvoiceModel> GetInvoiceList()
        {
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            List<InvoiceModel> lstInvoice = new List<InvoiceModel>();
            var InvoiceList = db.tbl_Invoice.ToList();
            if (InvoiceList != null)
            {
                foreach (var Invoice in InvoiceList)
                {
                    lstInvoice.Add(new InvoiceModel()
                    {
                        CustId = Invoice.CustId,
                        Amount = Invoice.Amount,
                        Discount = Invoice.Discount,
                        TotalAmt = Invoice.TotalAmt,
                        InvoiceDateString = Invoice.InvoiceDate.ToString("dd/MM/yyyy"),
                        Vat = Invoice.Vat,
                        Time = Invoice.Time,
                        PayMode = Invoice.PayMode,
                        Paid = Invoice.Paid,
                        Note = Invoice.Note,
                        Advance = Invoice.Advance,
                        Point = Invoice.Point,
                        Person = Invoice.Person,
                        InvoiceId = Invoice.InvoiceId,
                        SGST = Invoice.SGST,
                        CGST = Invoice.CGST,
                        IGST = Invoice.IGST,
                        AutoInvoiceID = Invoice.AutoInvoiceID,
                    });
                }
            }
            return lstInvoice;
        }
    }

}