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
            if (result.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "Trainee").GetAwaiter().GetResult();
            }
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
        public IActionResult Delete(string Id)
        {

            var staffindb = _db.Users.SingleOrDefault(item => item.Id == Id);
            _db.Users.Remove(staffindb);
            _db.SaveChanges();

            return RedirectToAction("ManageTrainee");
        }

        public ActionResult Edit(string Id)
        {

            var todoInDb = _db.TraineeProfiles.Include(x => x.User).SingleOrDefault(item => item.User.Id == Id);

            return View(todoInDb);
        }

         [HttpPost]
      public ActionResult Edit(TraineeProfile traineeProfile)
      {
         
         var traineeinDb = _db.TraineeProfiles.Include(x => x.User).SingleOrDefault(x => x.UserId == traineeProfile.User.Id);
         var user = _db.Users.SingleOrDefault(x => x.Id == traineeProfile.User.Id);
         user.FullName = traineeProfile.User.FullName;
         user.Address = traineeProfile.User.Address;
         user.Age = traineeProfile.User.Age;
         traineeinDb.DateOfBirth = traineeProfile.DateOfBirth;
         traineeProfile.Education = traineeProfile.Education;

         _db.SaveChanges();

         return RedirectToAction("ManageTrainee");
      }
      public ActionResult SearchTraineeByName(string searchString)
        {
            var trainees = _db.TraineeProfiles.Include(x => x.User);
                        

            if (!String.IsNullOrEmpty(searchString))
            {
                var result = trainees.Where(s => s.User.FullName.Contains(searchString));
                return View(result.ToList());
            }
            return RedirectToAction("ManageTrainee");

        }

        public ActionResult SearchTraineeByAge(int searchString)
        {
            var trainees = _db.TraineeProfiles.Include(x => x.User);


            if (searchString != null)
            {
                var result = trainees.Where(s => s.User.Age == searchString);
                return View(result.ToList());
            }
            return RedirectToAction("ManageTrainee");

        }

    }
}
