using AppDevGCD0805.Data;
using AppDevGCD0805.Data.Migrations;
using AppDevGCD0805.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraineeProfile = AppDevGCD0805.Models.TraineeProfile;

namespace AppDevGCD0805.Controllers
{
    public class TrainingStaffsController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        private ApplicationDbContext _db;
        public TrainingStaffsController(ApplicationDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateTrainee()
        {
            TraineeProfile model = new TraineeProfile();
            return View(model);
        }
        [HttpPost]
        public IActionResult CreateTrainee(TraineeProfile traineeProfile)
        {
            var user = traineeProfile.User;
            IdentityResult result = _userManager.CreateAsync(user, user.PasswordHash).GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(user, "Trainee");

            var trainee = new TraineeProfile();
            trainee.UserId = user.Id;
            trainee.DateOfBirth = traineeProfile.DateOfBirth;
            trainee.Education = traineeProfile.Education;

            _db.TraineeProfiles.Add(trainee);
            _db.SaveChanges();
            return RedirectToAction("ManageTrainee");
        }
         public IActionResult ManageTrainee()
         {
            var traineeinDB = _db.TraineeProfiles.Include(x => x.User).ToList();

            return View(traineeinDB);
         }
   }
}
