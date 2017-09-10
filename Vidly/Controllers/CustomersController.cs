using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    [RoutePrefix("customers")]
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c=> c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var selectedCustomer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (selectedCustomer == null) return HttpNotFound();
            return View(selectedCustomer);
        }
    }
}