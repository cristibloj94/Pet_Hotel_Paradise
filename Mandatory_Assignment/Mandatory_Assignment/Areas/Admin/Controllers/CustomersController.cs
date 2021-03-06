﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mandatory_Assignment.Models;
using Mandatory_Assignment.Infrastructure;

namespace Mandatory_Assignment.Areas.Admin.Controllers
{
    public class CustomersController : Controller
    {
        private List<SelectListItem> viewReservations = new List<SelectListItem>();
        private Repository repository = new Repository();
        // GET: Admin/Customers
        public ActionResult Index(string ViewReservations)
        {
            List<SelectListItem> viewReservations = new List<SelectListItem>();

            if (Session["repository"] == null)
            {
                Session["repository"] = repository;
            }
            else
            {
                repository = (Repository)Session["repository"];
            }

            foreach (Customer customer in repository.Customers)
            {
                viewReservations.Add(new SelectListItem { Text = (customer.Firstname + " " + customer.Lastname), Value = (customer.Firstname + " " + customer.Lastname) });
            }

            Utilities.SortSelectList(viewReservations);

            ViewBag.repository = repository;
            ViewBag.ViewReservations = viewReservations;
            ViewBag.Selected = ViewReservations;
            return View();
        }
    }
}