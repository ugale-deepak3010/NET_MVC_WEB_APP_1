using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginX(string UserNamex, string Passwordx)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)     // model bind
        {
            return View();
        }
    }
}