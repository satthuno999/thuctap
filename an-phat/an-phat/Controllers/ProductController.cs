using an_phat.Models;
using DataAccess.Framework;
using DataAccess.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace an_phat.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpGet]
        public ActionResult Product()
        {
            using (AnPhatDBContext data = new AnPhatDBContext())
            {
                List<Image> images = data.Images.ToList();
                List<Product> products = data.Products.ToList();
                List<ProductImage> productImages = data.ProductImage.ToList();
                var a = from img in images
                        join pimg in productImages on img.ID equals pimg.ImageID into table1
                        from pimg in table1.ToList()
                        join p in products on pimg.ProductID equals p.ID into table2 
                        from  p in table2.ToList()
                        
                        select new ProductModelView
                        {
                            ImageID = img.ID,
                            ProductID = p.ID,
                            ImageUrl = img.Url,
                            ProductName = p.ProductName
                        };
                return View(a);
            }
        }

    }
}