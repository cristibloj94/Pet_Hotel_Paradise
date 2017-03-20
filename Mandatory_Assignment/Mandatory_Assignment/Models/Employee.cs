using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mandatory_Assignment.Models
{
    public class Employee : Person
    {
        // properties
        public string initials { get; set; }
        public List<Reservation> reservations { get; set; }

        // constructors
        public Employee(int personID, string firstname, string lastname, string initials, string phone)
            : base(personID, firstname, lastname, phone)
        {
            this.initials = initials;
            reservations = new List<Reservation>();
        }

        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }
    }
}