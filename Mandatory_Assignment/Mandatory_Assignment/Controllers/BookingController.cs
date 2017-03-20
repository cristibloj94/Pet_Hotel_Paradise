﻿using System;
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
            if (Session["speciesList"] == null)
            {
                foreach (KeyValuePair<string, int> kvp in repository.Prices)
                {
                    speciesList.Add(new SelectListItem { Text = kvp.Key, Value = kvp.Key });
                }
                Session["speciesList"] = speciesList;
            }
            else
            {
                speciesList = (List<SelectListItem>)Session["speciesList"];
            }
            Utilities.SortSelectList(speciesList);
            ViewBag.speciesList = speciesList;
            ViewBag.repository = repository;
            return View();
        }

        [HttpPost]
        public ActionResult BookReservation(Reservation res)
        {
            Repository repository = new Repository();
            if (Session["repository"] == null)
            {
                Session["repository"] = repository;
            }
            else
            {
                repository = (Repository)Session["repository"];
            }
            repository.Reservations.Add(res);
            return View();
        }
    }
}