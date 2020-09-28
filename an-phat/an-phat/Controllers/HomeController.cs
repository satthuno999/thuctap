
using an_phat.Models;
using DataAccess.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace an_phat.Controllers
{

    public class HomeController : Controller
    {
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
        public ActionResult Login(LoginModel loginModel)

        {
            

            //if (Authenticated)

            //{

            //    string Return_Url = Request.QueryString["ReturnUrl"];

            //    if (Return_Url == null)

            //    {

            //        Response.Redirect("/Home/Index");

            //    }

            //    else

            //    {

            //        Response.Redirect(Return_Url);

            //    }

            //}
            return View(loginModel);
        }

        [HttpGet]
        public ActionResult Register()
        {
            using (var dbContext = new AnPhatDBContext())
            {
                RegistrationModel user = new RegistrationModel();
                var a = dbContext.Districts.ToList();
                ViewBag.DistrictList = a;

                return View();
            }
        }
    }
}

//[HttpPost]
//public ActionResult Register(UserModel user)
//{


//if (ModelState.IsValid)
//{
//    // Create company and attempt to register the user
//    try
//    {
//        WebSecurity.CreateUserAndAccount(user.UserName,
//                                           user.UserPassword,
//                                            propertyValues: new
//                                            {
//                                                Email = user.UserEmail,

//                                                PhoneNumber = user.UserEmail,


////                                            });

//        db.Users.Add(user.);

//        var newuser = db.UserProfiles.FirstOrDefault(u => u.UserName == addCompanyViewModel.User.UserName);
//        if (newuser != null)
//        {
//            newuser.CompanyICanEdit = addCompanyViewModel.Company;
//            db.Entry(newuser).State = EntityState.Modified;
//            db.SaveChanges();
//            return RedirectToAction("Index");
//        }
//        else
//        {
//            ModelState.AddModelError("", "New user wasn't added");
//        }
//    }
//    catch (MembershipCreateUserException e)
//    {
//        ModelState.AddModelError("", Mywebsite.Controllers.AccountController.ErrorCodeToString(e.StatusCode));
//    }

//}


//        return View(user);
//    }
//}
