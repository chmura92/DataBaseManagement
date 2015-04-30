using MovieRentalOnline.DAL;
using MovieRentalOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace MovieRentalOnline.Controllers
{
    public class ActorController : Controller
    {
        private RentalContext db = new RentalContext();
        // GET: Actor
        public async Task<ActionResult> Index()
        {
            return View(await db.Actors.ToListAsync());
        }
        // GET: Actor/Details/id
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = await db.Actors.FindAsync(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Details", actor);
        }
        // GET: People/Create
        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        // POST: Actor/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "FirstName,MiddleName,LastName,DateOfBirth,Biography,PhotoFileName")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Actors.Add(actor);
                await db.SaveChangesAsync();
                return Json(new { success = true});
            }
            return PartialView("_Create",actor);
        }
        // GET: Actor/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = await db.Actors.FindAsync(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Edit", actor);
        }

        // POST: Actor/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "FirstName,MiddleName,LastName,DateOfBirth,Biography,PhotoFileName")] Actor actor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actor).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return Json(new { success = true });
            }
            return PartialView("_Edit", actor);
        }

        // GET: Actor/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Actor actor = await db.Actors.FindAsync(id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return PartialView("_Delete", actor);
        }

        // POST: Actor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Actor actor = await db.Actors.FindAsync(id);
            db.Actors.Remove(actor);
            await db.SaveChangesAsync();
            return Json(new { success = true });
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

       

    }
}