//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace an_phat.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string ShipAddress { get; set; }
        public Nullable<int> Phone { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<double> OrderTotal { get; set; }
        public string OrderStatus { get; set; }
    
        public virtual User User { get; set; }
    }
}
