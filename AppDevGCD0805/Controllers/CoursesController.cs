using System.Collections.Generic;
using System.Linq;
using AppDevGCD0805.Data;
using AppDevGCD0805.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppDevGCD0805.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _db;
        public CoursesController(ApplicationDbContext db)
        {
            _db = db;
        }



        public ActionResult Index()
        {
            var model = _db.Courses.Include(x => x.Category);
            return View(model);
        }

        [HttpGet]

        public IActionResult Create()
        {
            var model = _db.Categories.ToList();
            ViewBag.name = model;
            return View(ViewBag.name);
        }


        [HttpPost]
        public IActionResult Create(Course course)
        {

            _db.Courses.Add(course);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var courseinDb = _db.Courses.SingleOrDefault(item => item.Id == Id);
            _db.Courses.Remove(courseinDb);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {

            var todoInDb = _db.Courses
                .SingleOrDefault(t => t.Id == id);

            return View(todoInDb);
        }

        [HttpPost]
        public ActionResult Edit(Course course)
        {
            var courseinDb = _db.Courses.SingleOrDefault(item => item.Id == course.Id);
            courseinDb.Name = course.Name;
            courseinDb.Description = course.Description;
            courseinDb.CategoryId = course.CategoryId;

            _db.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}