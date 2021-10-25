using AppDevGCD0805.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDevGCD0805.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AppDevGCD0805.Controllers
{

	public class TrainersController : Controller
	{
      private ApplicationDbContext _db;
      private readonly UserManager<User> _userManager;
      private readonly RoleManager<IdentityRole> _roleManager;

      public TrainersController(ApplicationDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
      {
         _db = db;
         _userManager = userManager;
         _roleManager = roleManager;

      }
      // GET: Trainers
      [HttpGet]
      public ActionResult Index()
      {
         var userId = _userManager.GetUserId(User);
         var trainerinDb = _db.TrainerProfiles.Include(x=>x.User).SingleOrDefault(item => item.UserId == userId);
        
         return View(trainerinDb);
      }

      public ActionResult EditProfile(string Id)
      {

         var todoInDb = _db.TrainerProfiles.Include(x => x.User)
           .SingleOrDefault(item => item.UserId == Id);

         return View(todoInDb);
      }

      [HttpPost]
      public ActionResult EditProfile(TrainerProfile trainerProfile)
      {
         var userId = _userManager.GetUserId(User);
         var trainerinDb = _db.TrainerProfiles.Include(x => x.User).SingleOrDefault(item => item.UserId == userId);
         
         trainerinDb.User.FullName = trainerProfile.User.FullName;
         trainerinDb.User.Address = trainerProfile.User.Address;
         trainerinDb.User.Age = trainerProfile.User.Age;
         trainerinDb.Specialty = trainerProfile.Specialty;

         _db.SaveChanges();

         return RedirectToAction("Index");
      }

      public ActionResult ViewCourse()
      {
         var userId = _userManager.GetUserId(User);
         var courseinDb = _db.AssignTrainerCourses.Include(x => x.Course).ThenInclude(x=>x.Category)
            .Where(x=>x.UserId==userId).ToList();

         return View(courseinDb);
      }

      public ActionResult ViewTrainee(int id)
      {
         var query = _db.TraineeProfiles.Include(x => x.AssignTraineeCourses).Include(x => x.User).AsQueryable();

         var traineeinDb = query.Where(x =>x.AssignTraineeCourses.Where(x=>x.CourseId==id).Any()).ToList(); 

         return View(traineeinDb);
      }
   }
}
