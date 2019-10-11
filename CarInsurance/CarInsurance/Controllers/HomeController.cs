using CarInsurance.Models;
using CarInsurance.ViewModels;
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
                   // customer.Quote = quote;


                    var today = DateTime.Today;
                    int total = 50;


                  
                    
                        var dob = Convert.ToDateTime(customer.DateOfBirth); // getting age and price additional cost for quote


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
                        
                        
                            if (customer.CarYear < 2000) //getting year of car and additional cost for quote
                    {
                                total = total + 25;
                            }
                            else if (customer.CarYear > 2015)
                            {
                                total = total + 25;
                            }
                      
                        
                            if (customer.CarMake == "Porsche") //getting make of car and additional cost for quote
                    {
                                total = total + 25;
                            }
                        
                        
                            if (customer.CarModel == "911 Carrera") //getting model and additional cost for quote
                    {
                                total = total + 25;
                            }
                        //}
                    if (customer.NumberOfTickets > 0)  //getting number of speeding tickets and additional cost for quote
                    {
                        total = total + (numberOfTickets * 10);
                    }
              
                           
                        
                            if (customer.DUI == "yes") //getting  DUI and additinal cost for quote
                    {
                                total = Convert.ToInt32(total * .25 + total);
                            }
                       
                        
                            if (customer.FullOrLiability == "Full") // getting full coverage additional cost for quote
                    {
                                total = Convert.ToInt32(total * .50 + total);

                            }
                        

                        customer.Quote = total;

                        db.Customers.Add(customer);
                        db.SaveChanges();

                        @ViewBag.Total = total;

                     
                    }
                    return View("Success");
                }

            }
        }



    }
