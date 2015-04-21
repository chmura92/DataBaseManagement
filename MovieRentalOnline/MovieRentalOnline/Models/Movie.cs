using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Movie
    {
        public Movie()
        { //polaczenia wiele dowielu
            this.Actors = new HashSet<Actor>(); 
            this.Directors = new HashSet<Director>();
            this.Genres = new HashSet<Genre>();

        }
        public int MovieId { get; set; }   //klucz glowny
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PhotoFileName { get; set; }    //lokalizacja pliku z plakatem/okladka, przyda sie przy budowie widokow

        public virtual ICollection<Actor> Actors { get; set; } //polaczone z wieloma aktorami
        public virtual ICollection<Director> Directors { get; set; } //polaczone z wieloma rezyserami
        public virtual ICollection<Genre> Genres { get; set; } //polaczone z wieloma gatunkami
        public virtual ICollection<Product> Products { get; set; } //polaczone z wieloma produktami
    }
}