using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentalOnline.DAL;
using MovieRentalOnline.Models;

namespace MovieRentalOnline.Controllers
{
    public class HomeController : Controller
    {
        private RentalContext db = new RentalContext();
        public ActionResult Index()
        {
            // dodawanie nowych obiektow
            Actor a1 = new Actor {FirstName = "nowyy", LastName = "nowyy", DateOfBirth = DateTime.Today};
            db.Actors.Add(a1);
            db.SaveChanges();

            // pobieranie obiektow z bazy
            var lista = db.Actors.ToList();


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}