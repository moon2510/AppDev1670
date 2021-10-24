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
	public class TraineesController : Controller
	{

      private ApplicationDbContext _db;
      private readonly UserManager<User> _userManager;
      private readonly RoleManager<IdentityRole> _roleManager;

      public TraineesController(ApplicationDbContext db, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
      {
         _db = db;
         _userManager = userManager;
         _roleManager = roleManager;

      }
      // GET: Trainees
      [HttpGet]
      public ActionResult Index()
      {
         var userId = _userManager.GetUserId(User);
         var traineeinDb = _db.TraineeProfiles.Include(x => x.User).SingleOrDefault(item => item.UserId == userId);

         return View(traineeinDb);
      }

      
     
      public ActionResult ViewCourse()
      {
         var userId = _userManager.GetUserId(User);
         var courseinDb = _db.AssignTraineeCourses.Include(x => x.Course).ThenInclude(x => x.Category)
            .Where(x => x.UserId == userId).ToList();

         return View(courseinDb);
      }

      
   }
}
