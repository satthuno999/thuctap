using an_phat.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace an_phat.Controllers
{
    public class ProductController : Controller
    {
        private AnPhatDB data = new AnPhatDB();
        // GET: Product
        public ActionResult Product()
        {
            var test = data.Images.ToList();
            return View(data.Images.ToList());
        }
    }
}