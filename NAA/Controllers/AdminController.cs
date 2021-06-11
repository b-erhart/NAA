using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NAA.Data.Models.Domain;
using NAA.Models;
using NAA.Services.Service;
using NAA.Services.IService;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System.Globalization;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.EntityFramework;

namespace NAA.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext context;
        private IUserService userService;

        public AdminController()
        {
            context = new ApplicationDbContext();
            userService = new UserService();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult GetUsers()
        {
            return View(userService.GetUsers());
        }

        public ActionResult DeleteUser(String userId)
        {
            return View(userService.GetUser(userId));
        }
        [HttpPost]
        public ActionResult DeleteUser(User user)
        {
            try
            {
                ApplicationUser dbUser = context.Users.Find(user.UserId);
                context.Users.Remove(dbUser);
                context.SaveChanges();
                userService.DeleteUser(user.UserId);
                return RedirectToAction("GetUsers");
            }
            catch (Exception)
            {
                return View();
            }
        }

        public ActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddRole(FormCollection collection)
        {
                IdentityRole role = new IdentityRole(collection["RoleName"]);
                context.Roles.Add(role);
                context.SaveChanges();
                return RedirectToAction("GetUsers");
        }

        public ActionResult ManageUserRoles()
        {
            var userList = context.Users.OrderBy(
                u => u.UserName).ToList().Select(
                uu => new SelectListItem
                {
                    Value = uu.UserName.ToString(),
                    Text = uu.UserName
                }).ToList();
            ViewBag.Users = userList;

            var roleList = context.Roles.OrderBy(
                r => r.Name).ToList().Select(
                rr => new SelectListItem
                {
                    Value = rr.Name.ToString(),
                    Text = rr.Name
                }).ToList();
            ViewBag.Roles = roleList;
            return View();
        }

    }
}