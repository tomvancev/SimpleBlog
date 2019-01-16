using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Login() => View();

        [HttpPost]
        public ActionResult Login(AuthLogin form){
            if(!ModelState.IsValid)
                 return View(form);
            if(form.Username != "rainbow dash")
            {
                ModelState.AddModelError("Username", "Username invalid");
                return View(form);
            }

            return Content("The Form is Valid");
        }
    }
}