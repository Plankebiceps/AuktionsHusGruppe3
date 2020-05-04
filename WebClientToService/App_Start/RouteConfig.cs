using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebClientToService {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CustomerCreateAccount",
                url: "CustomerCreateAccount/{action}/{id}",
                defaults: new { controller = "Account" }
            );

            routes.MapRoute(
                name: "Bid",
                url: "Auction/BidList/{action}/{id}",
                defaults: new { controller = "Bid", action = "BidList", id = UrlParameter.Optional }
            );

           
            routes.MapRoute(
                name: "Auction",
                url: "Auction/{action}/{id}",
                defaults: new { controller = "Auction" }
            );


            routes.MapRoute(
                name: "Login",
                url: "Account/{action}/{id}",
                defaults: new { controller = "Account", action = "CustomerLogin", id = UrlParameter.Optional });
            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
