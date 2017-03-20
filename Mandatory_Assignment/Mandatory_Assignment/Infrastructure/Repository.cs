using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mandatory_Assignment.Models;

namespace Mandatory_Assignment.Infrastructure
{
    public class Repository
    {
        Dictionary<string, int> prices = new Dictionary<string, int>();
        public Dictionary<string, int> Prices
        {
            get { return prices; }
        }

        List<Reservation> reservations = new List<Reservation>();
        public List<Reservation> Reservations
        {
            get { return reservations; }
        }

        List<Customer> customers = new List<Customer>();
        public List<Customer> Customers
        {
            get { return customers; }
        }

        List<Employee> employees = new List<Employee>();
        public List<Employee> Employees
        {
            get { return employees; }
        }

        public Repository()
        {
            prices.Add("Chinchilla", 80);
            prices.Add("Snake", 120);
            prices.Add("Hamster", 80);
            prices.Add("Dog", 180);
            prices.Add("Cat", 140);
            prices.Add("Rabbit", 80);
            prices.Add("Iguana", 150);
            prices.Add("Guinea pig", 75);
            prices.Add("Canary", 60);
            prices.Add("Bird spider", 90);

            Customer c1 = new Customer(1, "Susan", "Peterson", "Borgergade 45", "8000", "Aarhus", "supe@xmail.dk", "21212121");
            Customer c2 = new Customer(2, "Brian", "Smith", "Algade 108", "8000", "Aarhus", "brsm@xmail.dk", "45454545");

            Employee e1 = new Employee(3, "Laura", "Johnson", "lajo", "48484848");
            Employee e2 = new Employee(4, "Joe", "McGuire", "jomc", "97979797");

            Reservation r1 = new Reservation(1, "Fido", "Dog", new DateTime(2014, 9, 2), new DateTime(2014, 9, 20), c1, e1);
            Reservation r2 = new Reservation(2, "Samson", "Dog", new DateTime(2014, 9, 14), new DateTime(2014, 9, 21), c1, e2);
            Reservation r3 = new Reservation(3, "Darla", "Cat", new DateTime(2014, 9, 7), new DateTime(2014, 9, 10), c2, e2);

            e1.AddReservation(r1);
            e2.AddReservation(r2);
            e2.AddReservation(r3);

            c1.AddReservation(r1);
            c1.AddReservation(r2);
            c2.AddReservation(r3);

            reservations.Add(r1);
            reservations.Add(r2);
            reservations.Add(r3);

            customers.Add(c1);
            customers.Add(c2);

            employees.Add(e1);
            employees.Add(e2);

        }
    }
}