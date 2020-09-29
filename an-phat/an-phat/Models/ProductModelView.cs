using DataAccess.Framework;
using DataAccess.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace an_phat.Models
{
    public class ProductModelView
    {
        
        public int ProductID { get; set; }
        public int ImageID { get; set; }
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
       
    }
}