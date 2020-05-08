using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.Models;
using WebClientToService.ServiceLayer;
using WebClientToService.ServiceRefAuction;
using WebClientToService.Controllers;

namespace WebClientToService.Controllers {
    public class HomeController : Controller {
        [AllowAnonymous]
        public ActionResult Index() {
            return View();
        }

        [AllowAnonymous]
        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CustomerLogin()
        {
            if (!Request.IsAuthenticated)
            {
                bool whatevs = false;
                WebCustomerService webCustomerService = new WebCustomerService();
                string Email = null;
                string Password = null;
                whatevs = webCustomerService.LoginCustomer(Email, Password);
                WebCustomer webCustomer = new WebCustomer();
                Session["FirstName"] = webCustomer.FirstName;
                if (whatevs == true)
                {
                    /*HttpContext.GetOwinContext().Authentication.Challenge(
                    new AuthenticationProperties { RedirectUri = "/" },
                        OpenIdConnectAuthenticationDefaults.AuthenticationType
                    );*/
                    string FirstName = Guid.NewGuid().ToString();
                    Session["FirstName"] = FirstName;
                    var cookie = new HttpCookie("FirstName");
                    cookie.Value = FirstName;
                    Response.Cookies.Add(cookie);
                    //FormsAuthentication.SetAuthCookie(webCustomer.Email, true);
                    return RedirectToAction("Index", "Home");
                }
                return Private();
            }
            else
            {
                ModelState.AddModelError("", "Wrong email and/or password");
                return RedirectToAction("CustomerLogin");
            }
        }

        [Authorize]
        public ActionResult Private()
        {
            try
            {
                if (Request.IsAuthenticated)
                {
                    return PartialView("_LoginPartial");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer()
        {
            bool createdAccount = false;
            string firstName = null;
            string lastName = null;
            string address = null;
            string email = null;
            string password = null;
            WebCustomer webCustomer = new WebCustomer
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                Email = email,
                Password = password,
            };
            WebCustomerService webCustomerService = new WebCustomerService();
            createdAccount = webCustomerService.CreateCustomerAccount(webCustomer);
            if (createdAccount == true)
            {
                return View();
                //return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Email already in use.");
                return RedirectToAction("CreateCustomer", "Home");
            }
        }
    }
}