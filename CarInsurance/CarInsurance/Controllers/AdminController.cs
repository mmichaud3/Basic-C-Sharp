using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (Car_InsuranceEntities db = new Car_InsuranceEntities())
            {
                var customers = db.Customers.Where(x => x.Quoted == null).ToList();

                var customerVMs = new List<CustomerVM>();
                foreach (var customer in customers)
                {
                    var customerVM = new CustomerVM();
                    customerVM.Id = customer.Id;
                    customerVM.FirstName = customer.FirstName;
                    customerVM.LastName = customer.LastName;
                    customerVM.EmailAddress = customer.EmailAddress;
                    customerVM.Quote = Convert.ToInt32(customer.Quote);


                    customerVMs.Add(customerVM);
                }
                return View(customerVMs);
            }
        }
    }
}

                    
                  
    