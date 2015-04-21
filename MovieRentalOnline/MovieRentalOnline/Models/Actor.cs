using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Actor
    {
        public Actor() { }
        public int ActorId { get; set; } //klucz glowny
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Biography { get; set; }
        public string PhotoFileName { get; set; }   //lokalizacja pliku ze zdjeciem, przyda sie przy budowie widokow

        public virtual ICollection<Movie> Movies { get; set; }  //polaczone z wieloma filmami

        
    }
}