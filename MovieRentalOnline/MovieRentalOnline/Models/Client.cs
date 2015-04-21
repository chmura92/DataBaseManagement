using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Client
    {
        public Client() { }
        public int ClientId { get; set; }   //klucz glowny
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } // hash hasła

        public virtual ICollection<Order> Orders { get; set; } //polaczone z wieloma zamowieniami
    }
}