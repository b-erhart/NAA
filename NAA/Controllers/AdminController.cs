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
        [Authorize(Roles = "Admin")]
        public ActionResult Dashboard()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        public ActionResult GetUsers()
        {
            return View(userService.GetUsers());
        }
        [Authorize(Roles = "Admin")]
        public ActionResult DeleteUser(String userId)
        {
            return View(userService.GetUser(userId));
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult DeleteUser(User user)
        {

                ApplicationUser dbUser = context.Users.Find(user.UserId);
                context.Users.Remove(dbUser);
                context.SaveChanges();
                userService.DeleteUser(user.UserId);
                return RedirectToAction("GetUsers");
        }
        [Authorize(Roles = "Admin")]
        public ActionResult AddRole()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult AddRole(FormCollection collection)
        {
                IdentityRole role = new IdentityRole(collection["RoleName"]);
                context.Roles.Add(role);
                context.SaveChanges();
                return RedirectToAction("Dashboard");
        }
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult ManageUserRoles(string userName, string roleName)
        {
            ApplicationUser user = context.Users.Where
                (u => u.UserName.Equals(userName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();
            var um = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var idResult = um.AddToRole(user.Id, roleName);

            var roleList = context.Roles.OrderBy
                (r => r.Name).ToList().Select
                (rr => new SelectListItem
                {
                    Value = rr.Name.ToString(),
                    Text = rr.Name
                }).ToList();
            ViewBag.Roles = roleList;

            var userList = context.Users.OrderBy
                (u => u.UserName).ToList().Select
                (uu => new SelectListItem
                {
                    Value = uu.UserName.ToString(),
                    Text = uu.UserName
                }).ToList();
            ViewBag.Users = userList;
            return View("Dashboard");
        }

    }
}