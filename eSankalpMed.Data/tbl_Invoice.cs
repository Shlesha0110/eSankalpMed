//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eSankalpMed.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Invoice
    {
        public Nullable<long> CustId { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public decimal TotalAmt { get; set; }
        public System.DateTime InvoiceDate { get; set; }
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
    }
}
