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
                string authId = Guid.NewGuid().ToString();
                Session["AuthId"] = authId;
                var cookie = new HttpCookie("AuthId");
                cookie.Value = authId;
                Response.Cookies.Add(cookie);
                //FormsAuthentication.SetAuthCookie(webCustomer.Email, true);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Wrong email and/or password");
                return RedirectToAction("Private");
            }
        }

        [Authorize]
        public ActionResult Private()
        {
            try
            {
                if(Request.Cookies["AuthId"].Value == Session["AuthId"].ToString())
                {
                    return View();
                }
                else
                {
                    return PartialView("_LoginPartial.cshtml");
                }
            }
            catch
            {
                return RedirectToAction("Index");
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