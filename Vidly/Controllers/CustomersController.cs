using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    [RoutePrefix("customers")]
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Yusuf DUYAR" },
                new Customer { Id = 2, Name = "Melike DUYAR" }
            };
        }
        
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var selectedCustomer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (selectedCustomer == null) return HttpNotFound();
            return View(selectedCustomer);
        }
    }
}