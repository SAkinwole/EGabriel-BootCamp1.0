using Authentication_Web.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authentication_Web.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private ApplicationUserManager _userManager;

        public AdminController()
        {
        }
        public AdminController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext()
                    .GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: Admin
        public ActionResult Index()
        {
            var users = UserManager.Users.ToList();

            var usersList = new List<AdminViewModel>();

            foreach (var user in users)
            {
                AdminViewModel adminModel = new AdminViewModel()
                {
                    Name = user.FirstName + " " + user.LastName,
                    Dob = user.Dob,
                    Salary = user.Salary,
                    Photo = "/Content/images/photos/" + user.Photo,
                    CreatedAt = user.CreatedAt
                };

                usersList.Add(adminModel);

            }
            return View(usersList);
        }
    }
}