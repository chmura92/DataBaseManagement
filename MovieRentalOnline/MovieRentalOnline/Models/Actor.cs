using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Actor
    {
        public Actor() { }
        public int Id { get; set; } //klucz glowny

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Biography")]
        public string Biography { get; set; }

        [Required]
        [Display(Name = "PhotoFileName")]
        public string PhotoFileName { get; set; }   //lokalizacja pliku ze zdjeciem, przyda sie przy budowie widokow

           


        public virtual ICollection<Movie> Movies { get; set; }  //polaczone z wieloma filmami

        
    }
}