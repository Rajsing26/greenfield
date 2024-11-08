using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb1.Controllers
{
    public class ShoppingController : Controller
    {
        // GET: Shopping
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddtoCart()
        {
            return View();
        }

        public ActionResult RemovefromCart()
        {
            return View();
        }
    }
}