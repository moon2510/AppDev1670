using AppDevGCD0805.Data;
using AppDevGCD0805.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Controllers
{
    public class AdminsController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private ApplicationDbContext _db;
        public AdminsController(ApplicationDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult CreateStaff()
        {
            User model = new User();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateStaff(User user)
        {
            IdentityResult result = _userManager.CreateAsync(user, "defaultStaff@123").GetAwaiter().GetResult();
            IdentityResult roleReulst = _userManager.AddToRoleAsync(user, "Staff").GetAwaiter().GetResult();
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ManageStaff()
        {
            var staffRoleId = _db.Roles.FirstOrDefault(x => x.Name == "Staff").Id;
            var user = _userManager.GetUsersInRoleAsync("Staff").Result;
            return View(user);
        }
        //[HttpGet]
        //public IActionResult Delete(int Id)
        //{
        //    var staffinDb = _db.Users.SingleOrDefault(item => item. == Id);
        //    _db.Categories.Remove(categoryinDb);
        //    _db.SaveChanges();

        //    return RedirectToAction("Index");
        //}
    }
}
