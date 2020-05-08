using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.ServiceLayer;
using WebClientToService.Models;
using System.Web.Security;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OpenIdConnect;

namespace WebClientToService.Controllers
{
    public class AccountController : Controller
    {
        /* EXPERIMENTAL COMPLETE REFORMAT MOST LIKELY RECOMMENDED */
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer(string firstName, string lastName, string address, string email, string password)
        {
            bool createdAccount = false;
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
                //return View();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Email already in use.");
                return RedirectToAction("CreateCustomerAccount", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomerLogin(string Email, string Password)
        {
            if(!Request.IsAuthenticated)
            {
            bool whatevs = false;
            WebCustomerService webCustomerService = new WebCustomerService();
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

        public ActionResult Private()
        {
            try
            {
                if(Request.IsAuthenticated)
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
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}