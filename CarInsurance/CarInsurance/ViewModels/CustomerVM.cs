using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.ViewModels
{
    public class CustomerVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string DateOfBirth { get; set; }
        public Nullable<int> CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string DUI { get; set; }
        public Nullable<int> NumberOfTickets { get; set; }
        public string FullOrLiability { get; set; }
        public int Quote { get; set; }
        public string Quoted { get; set; }
    }
}