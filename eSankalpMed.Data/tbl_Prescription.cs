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
    
    public partial class tbl_Prescription
    {
        public int Customer_Id { get; set; }
        public string Patient_Name { get; set; }
        public string Photo { get; set; }
        public System.DateTime Uploaded_Date { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Delivery_date { get; set; }
    }
}
