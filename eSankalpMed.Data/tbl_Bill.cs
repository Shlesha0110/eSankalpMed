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
    
    public partial class tbl_Bill
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
    }
}
