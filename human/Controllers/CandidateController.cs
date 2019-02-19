using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace human.Controllers
{
    public class CandidateController : Controller
    {
        // GET: Candidate
        public ViewResult Index()
        {
            List<SelectListItem> items_job = new List<SelectListItem>();

            items_job.Add(new SelectListItem { Text = "Choose Job", Value = "0", Selected = true });

            items_job.Add(new SelectListItem { Text = "IT", Value = "1" });

            items_job.Add(new SelectListItem { Text = "Machine", Value = "2" });

            items_job.Add(new SelectListItem { Text = "Worker", Value = "3" });

            List<SelectListItem> items_location = new List<SelectListItem>();

            items_location.Add(new SelectListItem { Text = "Choose Location", Value = "0", Selected = true });

            items_location.Add(new SelectListItem { Text = "Tokyo", Value = "1" });

            items_location.Add(new SelectListItem { Text = "Chiba", Value = "2" });

            items_location.Add(new SelectListItem { Text = "Saitama", Value = "3" });

            items_location.Add(new SelectListItem { Text = "Japan", Value = "4" });

            items_location.Add(new SelectListItem { Text = "Viet Nam", Value = "5" });

            items_location.Add(new SelectListItem { Text = "Foreign", Value = "6" });

            ViewBag.Job = items_job;
            ViewBag.Location = items_location;
            return View();
        }
    }
}