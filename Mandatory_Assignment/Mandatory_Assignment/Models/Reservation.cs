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
        public int reservationID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string petName { get; set; }
        [DataType(DataType.Date)]
        public DateTime birthdate { get; set; }
        public string specie { get; set; }
        [DataType(DataType.Date)]
        public DateTime startDate { get; set; }
        [Display(Name = "TAKE YOUR FUCKIN PET AT", Prompt = "When?")]
        [DataType(DataType.Date)]
        public DateTime endDate { get; set; }
        public Customer customer { get; set; }
        public Employee employee { get; set; }

        public Reservation() { }

        // constructors
        public Reservation(int reservationID, string petName, string specie, DateTime startDate, DateTime endDate, Customer customer, Employee employee)
        {
            this.reservationID = reservationID;
            this.petName = petName;
            this.specie = specie;
            this.startDate = startDate;
            this.endDate = endDate;
            this.customer = customer;
            this.employee = employee;
        }
    }
}