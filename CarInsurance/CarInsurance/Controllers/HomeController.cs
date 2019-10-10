using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Customer(string firstName, string lastName, string emailAddress,
                                     string dateOfBirth, int carYear, string carMake, string carModel,
                                     string dui, int numberOfTickets, string fullOrLiability)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(Convert.ToString(carYear)) ||
                string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(dui) ||
                string.IsNullOrEmpty(Convert.ToString(numberOfTickets)) || string.IsNullOrEmpty(fullOrLiability))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (Car_InsuranceEntities db = new Car_InsuranceEntities())
                {
                    var customer = new Customer();
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.EmailAddress = emailAddress;
                    customer.DateOfBirth = dateOfBirth;
                    customer.CarYear = carYear;
                    customer.CarMake = carMake;
                    customer.CarModel = carModel;
                    customer.DUI = dui;
                    customer.NumberOfTickets = numberOfTickets;
                    customer.FullOrLiability = fullOrLiability;
                    //customer.Quote = quote;

                    


                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
                return View("Success");
            }

        }



    }
}