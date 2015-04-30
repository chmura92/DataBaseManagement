using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MovieRentalOnline.Models;

namespace MovieRentalOnline.DAL
{
    public class RentalContext : DbContext
    {
        public RentalContext() : base("RentalContext"){}
        //static RentalContext()
        //{
        //    Database.SetInitializer<RentalContext>(new RentalInitializer());
        //}
        //a
        public DbSet<Actor> Actors {get; set;}
        public DbSet<Client> Clients {get; set;}
        public DbSet<Director>Directors {get; set;}
        public DbSet<Genre>Genres {get; set;}
        public DbSet<Language>Languages {get; set;}
        public DbSet<Movie>Movies {get; set;}
        public DbSet<Order>Orders {get; set;}
        public DbSet<PhysicalProduct>PhysicalProducts {get; set;}
        public DbSet<Product> Products{get; set;}
        public DbSet<Rent> Rents { get; set; }
        public DbSet<SoundTechnology>SoundTechnologys {get; set;}
        public DbSet<StorageMedium>StorageMediums {get; set;}
        public DbSet<VideoTechnology>VideoTechnologys {get; set;}
    }
}