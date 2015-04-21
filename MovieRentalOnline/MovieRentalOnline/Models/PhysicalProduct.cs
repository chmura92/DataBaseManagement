using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class PhysicalProduct
    {
        public PhysicalProduct() { }
        public int PhysicalProductId { get; set; } //klucz glowny
        public int ProductId { get; set; } //polaczone z jednym produktem
        public string Description { get; set; } //opis np stanu plyty, nie podajemy do klientow
        public bool IsHidden { get; set; } // w momecie wycofania plyty, ukrywamy ja. Nie chcemy usuwać żeby nie tracić danych

        public virtual ICollection<Rent> Rents{ get; set; }  //polaczone z wieloma wypozyczeniami
        public virtual Product Product { get; set; }  //polaczone z jednym produktem
    }
}