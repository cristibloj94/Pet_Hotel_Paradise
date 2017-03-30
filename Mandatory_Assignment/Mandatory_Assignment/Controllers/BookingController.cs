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
            res.specie = formData["speciesList"];
            if (Session["repository"] == null)
            {
                Session["repository"] = repository;
            }
            else
            {
                repository = (Repository)Session["repository"];
            }
            repository.Reservations.Add(res);
            return View(res);
        }
    }
}