using MovieRentalOnline.DAL;
using MovieRentalOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentalOnline.Controllers
{
    public class ActorController : Controller
    {
        private RentalContext db = new RentalContext();
        // GET: Actor
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View(db.Actors.ToList());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,MiddleName,LastName,DateOfBirth,Biography,PhotoFileName")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Actors.Add(actor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actor);
        }

       

    }
}