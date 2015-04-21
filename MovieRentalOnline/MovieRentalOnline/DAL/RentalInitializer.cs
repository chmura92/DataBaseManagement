using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieRentalOnline.Models;

namespace MovieRentalOnline.DAL
{
    public class RentalInitializer : DropCreateDatabaseAlways<RentalContext>  // niszczy baze przy kazdym uruchomieniu, do zmienienia pozniej
    {
        protected override void Seed(RentalContext context)
        {
            SeedRentalData(context);
            base.Seed(context);
        }

        private void SeedRentalData(RentalContext context) // wypelnienie danymi poczatkowymi
        {
            var Actors = new List<Actor>
            {//a
                new Actor() {FirstName = "Adam", LastName = "Malysz", DateOfBirth=new DateTime(1990, 3, 12)},
                new Actor() {FirstName = "Pawel", LastName = "Rozycki", DateOfBirth=new DateTime(1930, 5, 13)},
                new Actor() {FirstName = "Jas", LastName = "Nowak", DateOfBirth=new DateTime(1995, 4, 12)},
                new Actor() {FirstName = "Mateusz", LastName = "Kowalski", DateOfBirth=new DateTime(1960, 2, 12)},
            };
            Actors.ForEach(a => context.Actors.Add(a));
            context.SaveChanges();
        }

    }
}