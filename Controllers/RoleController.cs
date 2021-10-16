using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Trackerz.Models;
namespace Trackerz.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context;
        public RoleController()
        {
            context = new ApplicationDbContext();
        }
        // GET: Role
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }
        public ActionResult Create()
        {
            var Roles = new IdentityRole();
            return View(Roles);
        }
        public ActionResult RegisterRole()
        {
            return RedirectToAction("RegisterRole", "Account");
        }
        [HttpPost]
        public ActionResult Create(IdentityRole role)
        {
            context.Roles.Add(role);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}