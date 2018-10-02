using MacBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MacBookStore.Controllers
{
    public class GenreController : Controller
    {
        private Models.ApplicationDbContext db;

        public GenreController()
        {
            db = new Models.ApplicationDbContext();
        }

        // GET: Genre
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            if(ModelState.IsValid)
            {
                db.Genres.Add(genre);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}