using AjaxSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxSample.Controllers
{
    public class CustomerController : Controller
    {
        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Kim", 25));
            customers.Add(new Customer(1, "Kevin", 22));
            customers.Add(new Customer(2, "Hannah", 24));
            customers.Add(new Customer(3, "Joe", 35));
            customers.Add(new Customer(4, "Jay", 15));
            customers.Add(new Customer(5, "Kiki", 5));
  
        }

        // GET: Customer
        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer>tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[2]);

            return View("Customer", tuple);
        }

        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            return PartialView("_CustomerDetails", customers[Int32.Parse(CustomerNumber)]);
        }

    }
}