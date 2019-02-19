using human.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace human.Areas.Admin.Controllers
{
    public class PhanQuyenController : Controller
    {
        // GET: Admin/PhanQuyen
        humanEntities1 db = new humanEntities1();
        public ActionResult Index()
        {
            if (Session["fullname"] == null)
            {
                return RedirectToAction("Login", "Account");
            }
            User_level user_level = new User_level();
            return View(db.User_level.OrderBy(n => n.id));
        }

        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Insert(User_level user_Level)
        {
            if (!ModelState.IsValid)
            {
                //return RedirectToAction("Insert", "PhanQuyen");
                return View();
            }
            db.User_level.Add(user_Level);
            db.SaveChanges();
            return RedirectToAction("Index", "PhanQuyen");
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            User_level user_Level = db.User_level.Find(id);
            if (user_Level == null)
            {
                return HttpNotFound();
            }
            db.User_level.Remove(user_Level);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}