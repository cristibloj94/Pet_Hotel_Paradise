using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mandatory_Assignment.Models
{
    public class Customer : Person
    {
        // properties
        public string address { get; set; }
        public string zipcode { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public List<Reservation> reservations { get; set; }

        // constructors
        public Customer(int personID, string firstname, string lastname, string address, string zipcode, string city, string email, string phone)
            : base(personID, firstname, lastname, phone)
        {
            this.address = address;
            this.zipcode = zipcode;
            this.city = city;
            this.email = email;
            reservations = new List<Reservation>();
        }

        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
    }
}