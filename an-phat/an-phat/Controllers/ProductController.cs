using an_phat.Models;
using DataAccess.Framework;
using DataAccess.Framework.Entity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace an_phat.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [HttpGet]
        public ActionResult Product(int? id)
        {
            if (!id.HasValue)
            {
                return View(new ProductModelView());
            }

            using (AnPhatDBContext data = new AnPhatDBContext())
            {
                List<Image> images = data.Images.ToList();
                List<Product> products = data.Products.ToList();
                List<ProductImage> productImages = data.ProductImage.ToList();
                List<PropertyCategory> propertyCategories = data.PropertyCategories.ToList();
                List<ProductProperty> productProperties = data.ProductProperties.ToList();
                var productObj = products.FirstOrDefault(x => x.ID == id);
                
                var productimg = from product in products
                                 join producti in productImages on product.ID equals producti.ProductID
                                 join img in images on producti.ImageID equals img.ID
                                 where product.ID == id
                                 select new ProductImageModel
                                 {
                                     URL = img.Url
                                 };
                var productper = from productperty in productProperties
                                 join propertycate in propertyCategories on productperty.PropertyID equals propertycate.ID
                                 where productperty.ProductID == id
                                 where propertycate.PriorityType == 1
                                 select new ProductPropertyModel
                                 {
                                     PropertyValue = productperty.PropertyValue,
                                     PropertyName = propertycate.PropertyName
                                 };
                
                ProductModelView test = new ProductModelView();
                test.productImageModels = productimg.ToList() ;
                test.Product = productObj;
                test.productPropertyModels = productper.ToList();
                return View(test);
            }
            
        }
    }
}