using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mandatory_Assignment.Models
{
    public class Person
    {
        // properties
        public int PersonID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }

        public Person() { }

        // constructors
        public Person(int PersonID, string Firstname, string Lastname, string Phone)
        {
            this.PersonID = PersonID;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            if (Phone.Length < 8)
            {
                throw new Exception("Please check your phone number, it seems to be invalid");
            }
            else
            {
                this.Phone = Phone;
            }
        }
    }
}