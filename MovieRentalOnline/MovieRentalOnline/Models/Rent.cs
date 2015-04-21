using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Rent
    {
        public Rent() { }
        public int RentId { get; set; } //klucz glowny
        public int PhysicalProductId { get; set; }
        public int OrderId { get; set; }
        public RentStatus RentStatus { get; set; } //Dopóki nie wysłane, można zamienić płytę i wysłać inną, żeby lepiej planować wysyłanie

        public virtual PhysicalProduct PhysicalProduct { get; set; }
        public virtual Order Order { get; set; }
    }

    public enum RentStatus
    {
        Sent,
        Waiting,
        Canceled
    }
}