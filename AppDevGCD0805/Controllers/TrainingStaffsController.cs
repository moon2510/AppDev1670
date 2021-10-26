using AppDevGCD0805.Data;
using AppDevGCD0805.Data.Migrations;
using AppDevGCD0805.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignTrainerCourse = AppDevGCD0805.Models.AssignTrainerCourse;
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
        public ActionResult SearchTrainee(string searchString, int age)
        {
            var trainees = _db.TraineeProfiles.Include(x => x.User);
                        

            if (!String.IsNullOrEmpty(searchString))
            {
                var result = trainees.Where(s => s.User.FullName.Contains(searchString));
                
                if( age != 0)
                {
                    var final = result.Where(s => s.User.Age == age);
                    return View(final.ToList());
                }
                return View(result.ToList());
            }

            if (age != 0)
            {
                var final = trainees.Where(s => s.User.Age == age);
                return View(final.ToList());
            }
            return RedirectToAction("ManageTrainee");

        }
      
       

        public ActionResult AssignTrainer(string id)
        {
           var model = new AssignTrainerCourse() { UserId=id };
           var trainers = _db.Users.SingleOrDefault(x => x.Id == id);
           ViewBag.User = trainers.FullName;

           var course = _db.Courses.ToList();
           var courseList = _db.Courses.Select(x => new { x.Id, x.Name }).ToList();

           ViewBag.CourseList = new SelectList(courseList, "Id", "Name");


           return View(model);

        }

      //public ActionResult ViewCourseTrainer(string id)
      //{
      //   var trainers = _db.Users.SingleOrDefault(x => x.Id == id);
      //   ViewBag.User = trainers.FullName;
      //   var courseinDb = _db.AssignTrainerCourses.Include(x => x.Course).ThenInclude(x => x.Category)
      //      .Where(x => x.UserId == id).ToList();

      //   return View("ViewCourseTrainer");
      //}
        [HttpPost]
        public ActionResult AssignTrainer(AssignTrainerCourse assignTrainerCourse)
        {
           _db.AssignTrainerCourses.Add(assignTrainerCourse);
           _db.SaveChanges();
           return View("Index");

        }

        public IActionResult ViewTrainer()
        {
            var trainerinDB = _db.TrainerProfiles.Include(x => x.User).ToList();

            return View(trainerinDB);
        }


    }
}
