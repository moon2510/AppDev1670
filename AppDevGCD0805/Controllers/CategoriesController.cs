using AppDevGCD0805.Data;
using AppDevGCD0805.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Controllers
{
	public class CategoriesController : Controller
	{
		private ApplicationDbContext _db;
		public CategoriesController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{

			return View(_db.Categories.ToList());
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Category category)
		{
			_db.Categories.Add(category);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Delete(int Id)
		{
			var categoryinDb = _db.Categories.SingleOrDefault(item => item.Id == Id);
			_db.Categories.Remove(categoryinDb);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

		[HttpGet]
		public ActionResult Edit(int id)
		{

			var todoInDb = _db.Categories
			  .SingleOrDefault(t => t.Id == id );
			
			return View(todoInDb);
		}

		[HttpPost]
		public ActionResult Edit(Category category)
		{
			var categoryinDb = _db.Categories.SingleOrDefault(item => item.Id == category.Id);
			categoryinDb.Name = category.Name;
			categoryinDb.Description = category.Description;

			_db.SaveChanges();

			return RedirectToAction("Index");
		}

	}
}
