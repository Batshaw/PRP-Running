using PRP_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PRP_Demo.ViewModels;

namespace PRP_Demo.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.Gender).ToList();
            if (customers.Count == 0)
            {
                return HttpNotFound();
            }
            if (User.IsInRole(RoleName.CanManageCustomers))
            {
                return View("Index", customers);
            }

            return View("IndexForGuest", customers);
        }

        public ActionResult CustomerProfile(int id)
        {
            var customer = _context.Customers.Include(c => c.Gender).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var trainingPlanList = _context.TrainingPlans.Where(p => p.Customer.Id == id).ToList();

            var viewModel = new CustomerProfileViewModel
            {
                Customer = customer,
                TrainingPlans = trainingPlanList
            };

            return View(viewModel);
        }

        public ActionResult AddCustomerForm()
        {
            var genders = _context.Genders.ToList();
            var addCustomerViewModel = new AddCustomerViewModel
            {
                Genders = genders
            };

            return View(addCustomerViewModel);
        }

        public ActionResult Save(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home", customer);
        }
    }
}