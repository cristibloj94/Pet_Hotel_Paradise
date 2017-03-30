using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mandatory_Assignment.Models
{
    public class Reservation
    {
        // properties
        public int ReservationID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string PetName { get; set; }
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public string Specie { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

        public Reservation() { }

        // constructors
        public Reservation(int ReservationID, string PetName, string Specie, DateTime StartDate, DateTime EndDate, Customer Customer, Employee Employee)
        {
            this.ReservationID = ReservationID;
            this.PetName = PetName;
            this.Specie = Specie;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Customer = Customer;
            this.Employee = Employee;
        }
    }
}