using BloodBankProject.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BloodBankProject.Core.Data;
using BloodBankProject.Core.Entities;
using BloodBankProject.Core.Utils;

namespace BloodBankProject.Web.Controllers
{
    public class AccountController : Controller
    {

        // GET: Account
        
        [ChildActionOnly]
        public ActionResult Register()
        {
            return PartialView("_RegisterForm", new RegisterViewModel());
        }

        [HttpPost]
        public ActionResult RegisterPage(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // save data to database

                using (var db = new BloodBankContext())
                {
                    var user = new User
                    {
                        Username = model.Username,
                        Password = Helpers.HashPassword(model.Password),
                        Email = model.Email,
                        IsActive = true,
                        CreateDate = DateTime.Now,
                        UserProfile = new Profile()
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                }

                FormsAuthentication.SetAuthCookie(model.Username, false);
                return Redirect("/");
            }
            return View("Register",model);
        }

        
        public ActionResult LoginForm()
        {
            return PartialView("_LoginForm", new LoginViewModel());
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db  = new BloodBankContext())
                {
                    var user = db.Users.SingleOrDefault(m => m.Username == model.Username);
                    if (user != null)
                    {
                        if (Helpers.VerifyPassword(user.Password, model.Password))
                        {
                            FormsAuthentication.SetAuthCookie(user.Username, false);
                            return Redirect("/");
                        }
                        else
                        {
                            ModelState.AddModelError("", "اسم المستخدم او كلمة المرور غير صحيحة!");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "اسم المستخدم او كلمة المرور غير صحيحة!");
                    }
                }
            }
            return View("Login", model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return Redirect("/");
        }

        [Authorize]
        public ActionResult ChangePasswordForm()
        {
            return PartialView("_ChangePasswordForm", new ChangePasswordViewModel());
        }

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                string username = User.Identity.Name;
                BloodBankProject.Core.Entities.User CurrentUser = null;

                using (var db = new BloodBankContext())
                {
                    CurrentUser = db.Users.SingleOrDefault(u => u.Username == username);
                    if (Helpers.VerifyPassword(CurrentUser.Password, model.CurrentPassword))
                    {
                        CurrentUser.Password = Helpers.HashPassword(model.Password);
                        db.SaveChanges();
                        return Redirect("/");
                    }
                    else
                    {
                        ModelState.AddModelError("", "كملة المرور الحالية غير صحيحة");
                    }
                }
            }
            return View("ChangePassword", model);
        }
    }
}