using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        /* ================ Database Object ================*/

        // Create Database object a class attribute
        private MyDbContext _context;
        // Define the _context object
        public CustomersController()
        {
            _context = new MyDbContext();
        }

        // Create , Override Dispose method for this database object.
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        /* ============== Actions ================*/
        // GET: Customers
        [Route("customers")]
        public ViewResult Index()
        {
            //var customers = GetCustomers().ToList();

            var customers = _context.Customers.Include(c=>c.MembershipType).ToList(); //Obtain customer list from DB.
            var indexcustomerviewmodel = new IndexCustomerViewModel()
            {
                Customers = customers
            };

            return View(indexcustomerviewmodel);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            //var customer = GetCustomers().SingleOrDefault(c=>c.Id==id);
            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            return View(customer);
        }

        //private IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer {Id = 1, Name = "John Smith"},
        //        new Customer {Id = 2, Name = "Mary Williams"}
        //    };
        //}
    }
}