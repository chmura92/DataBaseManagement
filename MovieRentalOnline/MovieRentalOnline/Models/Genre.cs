using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Genre
    {
        public Genre() { }
        public int GenreId { get; set; }   //klucz glowny
        public string GenreName { get; set; }
        public string IconFileName { get; set; }  //lokalizacja pliku z ikona, przyda sie przy budowie widokow

        public virtual ICollection<Movie> Movies { get; set; } //polaczone z wieloma filmami
    }
}