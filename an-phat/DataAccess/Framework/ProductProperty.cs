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
    
    public partial class ProductProperty
    {
        public int ID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> PropertyID { get; set; }
        public string PropertyValue { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual PropertyCategory PropertyCategory { get; set; }
    }
}
