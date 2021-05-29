using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eSankalpMed.Data;

namespace eSankalpMed.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string CustId { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public decimal TotalAmt { get; set; }
        public Nullable<decimal> Vat { get; set; }
        public string Time { get; set; }
        public string PayMode { get; set; }
        public string Paid { get; set; }
        public string Note { get; set; }
        public Nullable<decimal> Advance { get; set; }
        public Nullable<int> Point { get; set; }
        public string Person { get; set; }
        
        public Nullable<System.DateTime> Date { get; set; }
        
        public string SaveOrder(OrderModel model)
        {
            string Message = "";
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            var saveOrder = new tbl_Order()
            {

                //CustId = model.CustId,
                Amount = model.Amount,
                Discount = model.Discount,
                TotalAmt = model.TotalAmt,
                Vat = model.Vat,
                Time = model.Time,
                PayMode = model.PayMode,
                Paid = model.Paid,
                Note = model.Note,
                Advance = model.Advance,
                Point = model.Point,
                Person = model.Person,
                Date = model.Date

            };
            db.tbl_Order.Add(saveOrder);
            db.SaveChanges();
            return Message;
        }

        public List<OrderModel> GetOrderList()
        {
            esankal1_mazhichulEntities db = new esankal1_mazhichulEntities();
            List<OrderModel> lstOrder = new List<OrderModel>();
            var OrderList = db.tbl_Order.ToList();
            if (OrderList != null)
            {
                foreach (var Order in OrderList)
                {
                    lstOrder.Add(new OrderModel()
                    {
                        CustId = Order.CustId,
                        Amount = Order.Amount,
                        Discount = Order.Discount,
                        TotalAmt = Order.TotalAmt,
                        Vat = Order.Vat,
                        Time = Order.Time,
                        PayMode = Order.PayMode,
                        Paid = Order.Paid,
                        Note = Order.Note,
                        Advance = Order.Advance,
                        Point = Order.Point,
                        Person = Order.Person,
                        Date = Order.Date,

                    });
                }
            }
            return lstOrder;
        }
    }
}