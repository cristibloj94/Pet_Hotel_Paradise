using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mandatory_Assignment.Models;
using Mandatory_Assignment.Infrastructure;

namespace Mandatory_Assignment.Controllers
{
    public class BookingController : Controller
    {
        private List<SelectListItem> speciesList = new List<SelectListItem>();
        private Repository repository = new Repository();
        // GET: Booking
        public ActionResult Index()
        {
            List<SelectListItem> speciesList = new List<SelectListItem>();
            foreach (KeyValuePair<string, int> kvp in repository.Prices)
            {
                speciesList.Add(new SelectListItem { Text = kvp.Key, Value = kvp.Key });
            }
            Utilities.SortSelectList(speciesList);
            ViewBag.speciesList = speciesList;
            ViewBag.repository = repository;
            return View();
        }

        [HttpPost]
        public ActionResult BookReservation(Reservation res, FormCollection formData)
        {
            Repository repository = new Repository();
            res.Specie = formData["speciesList"];
            if (Session["repository"] == null)
            {
                Session["repository"] = repository;
            }
            else
            {
                repository = (Repository)Session["repository"];
            }
            // we need to check duplicate objects in our repo.
            // this is needed for showing our invoices by customer, where all duplicates are currently shown.
            // and that's because they are ALL added to our list, regardless of matches
            int counter = new int();    // so let's set a counter for duplicates
            counter = 0;    // and set our counter to zero
            foreach (Customer customer in repository.Customers) // and then check each existing customer in our repo and compare to the newly added one
            {
                if (customer.Equals(res.Customer))  // unfortunately, this comparative bullshit doesn't work
                {
                    counter = counter + 1;  // but if it did, it would add at least one thing
                }
            }
            if (counter < 1)    // so if it would be less than one
            {
                repository.Reservations.Add(res);   // it would add both the reservation to reservations list
                repository.Customers.Add(res.Customer); // and the customer to the customer list
            } else
            {
                repository.Reservations.Add(res); // or only the reservation to reservations list otherwise
            }
            ViewBag.repository = repository;
            return View(res);
        }
    }
}