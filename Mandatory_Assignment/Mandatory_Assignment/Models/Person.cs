using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mandatory_Assignment.Models
{
    public class Person
    {
        // properties
        public int personID { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }

        // constructors
        public Person(int personID, string firstname, string lastname, string phone)
        {
            this.personID = personID;
            this.firstname = firstname;
            this.lastname = lastname;
            if (phone.Length < 8)
            {
                throw new Exception("Please check your phone number, it seems to be invalid");
            }
            else
            {
                this.phone = phone;
            }
        }
    }
}