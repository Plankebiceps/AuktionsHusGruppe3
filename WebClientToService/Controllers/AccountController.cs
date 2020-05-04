using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.ServiceLayer;
using WebClientToService.Models;
using System.Web.Security;

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
            bool whatevs = false;
            WebCustomerService webCustomerService = new WebCustomerService();
            whatevs = webCustomerService.LoginCustomer(Email, Password);
            WebCustomer webCustomer = new WebCustomer();
            if (whatevs == true)
            {
                FormsAuthentication.SetAuthCookie(webCustomer.FirstName, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Wrong email and/or password");
                return RedirectToAction("CustomerLogin", "Home");
            }
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}