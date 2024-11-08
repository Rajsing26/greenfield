using EcommerceWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWeb1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer{ Id=1,Name="Rajsig",contact="9860856585" });
            customer.Add(new Customer{ Id = 2, Name = "shri", contact = "9860856585" });
            customer.Add(new Customer{ Id = 3, Name = "pratik", contact = "9860856585" });
            return View(customer);
        }
    }
}