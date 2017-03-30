using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mandatory_Assignment.Models
{
    public class Employee : Person
    {
        // properties
        public string Initials { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Employee() { }

        // constructors
        public Employee(int PersonID, string Firstname, string Lastname, string Initials, string Phone)
            : base(PersonID, Firstname, Lastname, Phone)
        {
            this.Initials = Initials;
            Reservations = new List<Reservation>();
        }

        public void AddReservation(Reservation Reservation)
        {
            Reservations.Add(Reservation);
        }
    }
}