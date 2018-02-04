using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class CustomersController : Controller
    {
        public static List<Customer> lstCustomer = new List<Customer>() { new Customer() { Id = 1, Name = "Customer1" },
                new Customer() { Id=2, Name = "Customer2"}};

        public ActionResult Index()
        {
            return View(lstCustomer);
        }

        public ActionResult Details(int id)
        {
            Customer objCustomer = lstCustomer.Single(x => x.Id == id);
            return View(objCustomer);
        }
    }
}