using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class SoundTechnology
    {
        public SoundTechnology() { }
        public int SoundTechnologyId { get; set; } //klucz glowny
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; } //polaczone z wieloma produktami
    }
}