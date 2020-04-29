using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClientToService.ServiceLayer;
using WebClientToService.Models;

namespace WebClientToService.Controllers
{
    public class AccountController : Controller
    {
        /* EXPERIMENTAL COMPLETE REFORMAT MOST LIKELY RECOMMENDED */
        /*
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCustomer(string firstName, string lastName, string address, string email, string password)
        {
            WebCustomer webCustomer = new WebCustomer
            {
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                CustomerEmail = email,
                Password = password,
            };
            WebCustomerService webCustomerService = new WebCustomerService();
            webCustomerService.CreateCustomerAccount(webCustomer);
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomerLogin(string emailToLookUp, string passwordToVerify)
        {
            WebCustomerService webCustomerService = new WebCustomerService();
            webCustomerService.LoginCustomer(emailToLookUp, passwordToVerify);


            return View();
        }
    }
}