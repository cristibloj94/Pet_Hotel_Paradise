using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mandatory_Assignment.Models;
using Mandatory_Assignment.Infrastructure;

namespace Mandatory_Assignment.Areas.Admin.Controllers
{
    public class InvoicesController : Controller
    {
        private Repository repository = new Repository();
        // GET: Admin/Invoices
        public ActionResult Index()
        {
            if (Session["repository"] == null)
            {
                Session["repository"] = repository;
            }
            else
            {
                repository = (Repository)Session["repository"];
            }
            ViewBag.repository = repository;
            return View();
        }
    }
}