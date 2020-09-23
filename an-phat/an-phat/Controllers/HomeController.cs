using an_phat.Data;
using an_phat.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace an_phat.Controllers
{

    public class HomeController : Controller
    {


        AnPhatDB123 db = new AnPhatDB123();
        

        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            
            return View();

        }

        [HttpPost]
        public ActionResult Login(UserModel user)
        {
            return View();
        }

        public ActionResult Register()
        {


            UserModel user = new UserModel();
            var a = db.Districts.ToList();
            ViewBag.DistrictList = a;
        
            return View();
        }
    }
}