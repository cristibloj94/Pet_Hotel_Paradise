using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mandatory_Assignment.Models
{
    public class Customer : Person
    {
        // properties
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Customer() { }

        // constructors
        public Customer(int PersonID, string Firstname, string Lastname, string Address, string Zipcode, string City, string Email, string Phone)
            : base(PersonID, Firstname, Lastname, Phone)
        {
            this.Address = Address;
            this.Zipcode = Zipcode;
            this.City = City;
            this.Email = Email;
            Reservations = new List<Reservation>();
        }

        public void AddReservation(Reservation Reservation)
        {
            Reservations.Add(Reservation);
        }
    }
}