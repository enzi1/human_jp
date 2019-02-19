using human.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace human.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account
        humanEntities1 db = new humanEntities1();
        public ActionResult Index()
        {
            if (Session["fullname"] == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            string email = collection["txtEmail"].ToString();
            string pass = collection["txtPassword"].ToString();
            User user = db.Users.SingleOrDefault(n => n.email == email && n.password == pass);
            if (user != null)
            {
                Session["userid"] = user.id;
                Session["fullname"] = user.fullname;
                return RedirectToAction("Index");
            }
            return Content("Tài khoản hoặc mật khẩu không đúng!");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            Session.Clear();
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetExpires(DateTime.UtcNow.AddHours(-1));
            Response.Cache.SetNoStore();
            return RedirectToAction("Login");
        }
    }
}