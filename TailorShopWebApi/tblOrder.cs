//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TailorShopWebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblOrder
    {
        public int OrderID { get; set; }
        public Nullable<int> CustomerID { get; set; }
        public Nullable<int> MeasurementID { get; set; }
        public Nullable<int> CloathID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<System.DateTime> DeliverDate { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public Nullable<int> PaymentStatus { get; set; }
        public string Reference_Image { get; set; }
        public string CloathPrice { get; set; }
    }
}
