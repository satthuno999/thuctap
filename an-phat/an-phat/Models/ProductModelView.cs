using DataAccess.Framework;
using DataAccess.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;

namespace an_phat.Models
{
    public class ProductModelView
    {
        public Product Product { get; set; }
        public List<ProductImageModel> productImageModels { get; set; }
        public List<ProductPropertyModel> productPropertyModels { get; set; }

    }
    
}