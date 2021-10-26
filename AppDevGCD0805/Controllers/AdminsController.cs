using AppDevGCD0805.Data;
using AppDevGCD0805.Models;
using AppDevGCD0805.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Controllers
{
   [Authorize(Roles = "Admin")]
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

        //Action Staff
        public IActionResult CreateStaff()
        {
            User model = new User();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateStaff(User user)
        {
            IdentityResult result = _userManager.CreateAsync(user, user.PasswordHash).GetAwaiter().GetResult();
            IdentityResult roleReulst = _userManager.AddToRoleAsync(user, "Staff").GetAwaiter().GetResult();
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ManageStaff()
        {
            
            var user = _userManager.GetUsersInRoleAsync("Staff").Result;
            return View(user);
        }
        [HttpGet]
        public IActionResult Delete(string Id)
        {
            
            var staffindb = _db.Users.SingleOrDefault(item => item.Id == Id);
            _db.Users.Remove(staffindb);
            _db.SaveChanges();

            return RedirectToAction("ManageStaff");
        }
        
        public ActionResult EditStaff(string Id)
        {

            var todoInDb = _db.Users
              .SingleOrDefault(item => item.Id == Id);

            return View(todoInDb);
        }

        [HttpPost]
        public ActionResult EditStaff(User user)
        {
            var staffinDb = _db.Users.SingleOrDefault(item => item.Id == user.Id);
            staffinDb.FullName = user.FullName;
            staffinDb.Address = user.Address;
            staffinDb.Age = user.Age;
            _db.SaveChanges();

            return RedirectToAction("ManageStaff");
        }


      //Action Trainer
      public IActionResult CreateTrainer()
        {
            TrainerProfile model = new TrainerProfile();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateTrainer(TrainerProfile trainerProfile)
        {
            var user = trainerProfile.User;
            IdentityResult result = _userManager.CreateAsync(user, user.PasswordHash).GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(user, "Trainer");

            var trainer = new TrainerProfile();
            trainer.UserId = user.Id;
            trainer.Specialty = trainerProfile.Specialty;
            
            _db.TrainerProfiles.Add(trainer);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ManageTrainer()
        {
            var trainerinDB = _db.TrainerProfiles.Include(x => x.User).ToList();
            
            return View(trainerinDB);
        }

         public ActionResult EditTrainer(string Id)
         {

            var todoInDb = _db.Users
              .SingleOrDefault(item => item.Id == Id);

            return View(todoInDb);
         }

         [HttpPost]
         public ActionResult EditTrainer(User user)
         {
            
            var trainerinDb = _db.Users.SingleOrDefault(item => item.Id == user.Id);
            trainerinDb.FullName = user.FullName;
            trainerinDb.Address = user.Address;
            trainerinDb.Age = user.Age;

            _db.SaveChanges();

            return RedirectToAction("ManageTrainer");
         }
         public ActionResult ChangePassword(string userId)
         {
            return View();
         }
         [HttpPost]
         public ActionResult ChangePassword(ChangePasswordViewModel request )
         {
            var user = _db.Users.SingleOrDefault(x=>x.Id==request.UserId);
            _userManager.RemovePasswordAsync(user).GetAwaiter().GetResult();
            _userManager.AddPasswordAsync(user, request.NewPassword).GetAwaiter().GetResult();
            _db.SaveChanges();

            _userManager.GetRolesAsync(user);
            return RedirectToAction("ManageTrainer");
         }

      public IActionResult DeleteTrainer(string Id)
         {

            var trainerindb = _db.Users.SingleOrDefault(item => item.Id == Id);
            _db.Users.Remove(trainerindb);
            _db.SaveChanges();

            return RedirectToAction("ManageTrainer");
         }



   }

}
