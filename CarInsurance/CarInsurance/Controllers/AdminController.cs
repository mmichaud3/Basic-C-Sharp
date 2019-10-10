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
                var today = DateTime.Today;
                int total = 50;


                var customers = db.Customers;//(from c in db.Customers
                                 //where c.Quote != null
                                 //select c).ToList();

                var customerVMs = new List<CustomerVM>();
                foreach (var customer in customers) // getting age and price additional cost for quote
                {
                    var dob = Convert.ToDateTime(customer.DateOfBirth);


                    if (dob.Year > today.Year - 25)
                    {
                        total = total + 25;
                    }
                    else if (dob.Year > today.Year - 18)
                    {
                        total = total + 100;
                    }
                    else if (dob.Year < today.Year - 100)
                    {
                        total = total + 25;
                    }
                    foreach (var customer2 in customers) //getting year of car and additional cost for quote
                    {
                        if (customer2.CarYear < 2000)
                        {
                            total = total + 25;
                        }
                        else if (customer2.CarYear > 2015)
                        {
                            total = total + 25;
                        }
                    }
                    foreach (var customer3 in customers) //getting make of car and additional cost for quote
                    {
                        if (customer3.CarMake == "Porsche")
                        {
                            total = total + 25;
                        }
                    }
                    foreach (var customer4 in customers) //getting model and additional cost for quote
                    {
                        if (customer4.CarModel == "911 Carrera")
                        {
                            total = total + 25;
                        }
                    }
                    foreach (var customer5 in customers)  //getting number of speeding tickets and additional cost for quote
                    {
                        total = total * 10 + total;
                    }
                    foreach (var customer6 in customers) //getting  DUI and additinal cost for quote
                    {
                        if (customer6.DUI == "yes")
                        {
                            total = Convert.ToInt32(total * .25 + total);
                        }
                    }
                    foreach (var customer7 in customers)  // getting full coverage additional cost for quote
                    {
                        if (customer7.FullOrLiability == "Full")
                        {
                            total = Convert.ToInt32(total * .50 + total);

                        }
                    }


                    customer.Quote = total;
                    db.Customers.Add(customer);
                    db.SaveChanges();

                    @ViewBag.Total = total;
                }
                return View("Index");
            }
        }

                    
                  
                    
                //var customerVM = new CustomerVM();
                //    customerVM.Quote = ag
        //            customerVM.Id = customer.Id;
        //            customerVM.FirstName = customer.FirstName;
        //            customerVM.LastName = customer.LastName;
        //            customerVM.EmailAddress = customer.EmailAddress;
        //            customerVM.DateOfBirth = customer.DateOfBirth;
        //            customerVM.CarYear = customer.CarYear;
        //            customerVM.CarMake = customer.CarMake;
        //            customerVM.CarModel = customer.CarModel;
        //            customerVM.DUI = customer.DUI;
        //            customerVM.NumberOfTickets = customer.NumberOfTickets;
        //            customerVM.FullOrLiability = customer.FullOrLiability;
        //            customerVM.Quote = customer.Quote;
        //            customerVMs.Add(customerVM);
        //        }
        //        return View(customerVMs);

        //    }
        //}
        //public ActionResult Quoted(int Id)
        //{
        //    using (Car_InsuranceEntities db = new Car_InsuranceEntities())
        //    {
        //        var customerVMs = new List<CustomerVM>();
        //        foreach (var customer in Customer) 
        //        {
        //            if (customer.date)
        //        }
        //    }
        //}
    }
}