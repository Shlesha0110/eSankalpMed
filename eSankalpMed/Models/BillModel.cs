using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eSankalpMed.Data;

namespace eSankalpMed.Models
{
    public class BillModel
    {

        public long BillId { get; set; }
        public long InvoiceId { get; set; }
        public long ItemId { get; set; }
        public decimal ItemQty { get; set; }
        public decimal ItemSaleAmt { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public decimal Rate { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string Model { get; set; }
        public Nullable<decimal> Size { get; set; }
        public Nullable<decimal> GST { get; set; }
        public Nullable<decimal> Disc { get; set; }
        public Nullable<decimal> TaxAmt { get; set; }
        public Nullable<int> DoseTime { get; set; }
        public Nullable<int> DoseQty { get; set; }

        public string SaveBill(BillModel model)
        {
            string Message = "";
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            var saveBill = new tbl_Bill()
            {

                InvoiceId = model.InvoiceId,
                ItemId = model.ItemId,
               
                ItemQty = model.ItemQty,
                ItemSaleAmt = model.ItemSaleAmt,
                Vat = model.Vat,
                Rate = model.Rate,
                Discount = model.Discount,
                Model = model.Model,
                Size = model.Size,
                GST = model.GST,
                Disc = model.Disc,
                TaxAmt = model.TaxAmt,
                DoseTime = model.DoseTime,
                DoseQty = model.DoseQty
             
            };
            db.tbl_Bill.Add(saveBill);
            db.SaveChanges();
            return Message;
            
        }
    }
}