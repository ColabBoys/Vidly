using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
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

        //adding customers code
        public ActionResult New()
        {
            var membeshipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                // so that the customer ID field required validation message doesnt show up for new entries 
                Customer = new Customer(),
                MembershipTypes = membeshipTypes
            };

            return View("CustomerForm", viewModel);
        }

        // if actions modify data it should NEVER be accessible by httpGet
        // mvc binds this model to the request data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Customer customer)
        {
            // validate based on checking to see if object is valid based on properties for customer class (get access to validation data
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                //send them back to the same view
                // place holder for validation elements to show what was not proper
                return View("CustomerForm", viewModel);
            }

            // this customer id is not in the form so have to get it there then this will not break
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                // update properties based on the properties in the form 2 ways to do this (tryupdatemodel(customerInDb) Issues (opens up security holes in app) OR  
                // can use a tool like auto mapper
                //Mapper.map(customer, customerInDb);
                customerInDb.Name = customer.Name;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.isSubscribedToNewsLetter = customer.isSubscribedToNewsLetter;
            }

            // add customer to db basic bitch approach and only when this method was to save when it was called create
            //_context.Customers.Add(customer);

            //to persist these changes call below
            // db context goes through all modified objects and based on changes will make sql statements during run time & run them in the db
            _context.SaveChanges();

            // redirects them to the index page of customer controller
            return RedirectToAction("Index", "Customers");
        }

        // if you put httpPost here it will fail every time with a 404 not sure why but it does!!!
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                // returns a 404
                return HttpNotFound();
            }

            // model behind this view (new) is the NewViewModel so need to create the view model instance and pass it to the view
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            // need to specify a view name or else the mvc routing will look for a view named Edit
            return View("CustomerForm", viewModel);
        }

        // GET: Customers
        public ViewResult Index()
        {
            //deferred execution, so itll only execute the query when it iterates through the customer
            //if you want to immediately execute add .ToList at end of customers
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details (int id)
        {
            //var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

    }
}