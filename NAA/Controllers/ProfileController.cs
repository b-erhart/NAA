using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAA.Data.Models.Domain;
using NAA.Services.IService;
using NAA.Services.Service;

namespace NAA.Controllers
{
    public class ProfileController : Controller
    {
        private IUserService userService;

        public ProfileController()
        {
            userService = new UserService();
        }

        public ActionResult Details()
        {
            User user = userService.GetUser((string)Session["UserId"]);
            return View(user);
        }

        // GET: Profile/Create
        public ActionResult Create()
        {
            User user = userService.GetUser((string)Session["UserId"]);
            ViewBag.NoNavigation = "yes";
            return View(user);
        }

        // POST: Profile/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                User dbUser = userService.GetUser((string)Session["UserId"]);

                if (string.IsNullOrEmpty(user.Address) || string.IsNullOrEmpty(user.Phone))
                {
                    Session["ErrorMessage"] = "Address and Phone are mandatory fields.";
                    return RedirectToAction("Create");
                }

                dbUser.Address = user.Address;
                dbUser.Phone = user.Phone;

                userService.UpdateUser(dbUser);

                ViewBag.NoNavigation = null;
                return RedirectToAction("Details", "Profile");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Edit/5
        public ActionResult Edit()
        {
            User user = userService.GetUser((string)Session["UserId"]);
            return View(user);
        }

        // POST: Profile/Edit/5
        [HttpPost]
        public ActionResult Edit(User user)
        {
            try
            {
                User dbUser = userService.GetUser((string)Session["UserId"]);

                if (string.IsNullOrEmpty(user.Address) || string.IsNullOrEmpty(user.Phone) || string.IsNullOrEmpty(user.Email))
                {
                    Session["ErrorMessage"] = "Address, Phone and Email are mandatory fields.";
                    return RedirectToAction("Edit");
                }

                dbUser.Address = user.Address;
                dbUser.Phone = user.Phone;
                dbUser.Email = user.Email;

                userService.UpdateUser(dbUser);

                return RedirectToAction("Details", "Profile");
            }
            catch
            {
                return View();
            }
        }

        // GET: Profile/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Profile/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
