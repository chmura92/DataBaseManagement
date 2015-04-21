using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Product
    {
        public Product()
        { //polaczenia wiele do wielu
            this.Languages = new HashSet<Language>();
            this.VideoTechnologys = new HashSet<VideoTechnology>();
            this.SoundTechnologys = new HashSet<SoundTechnology>();
            this.StorageMediums = new HashSet<StorageMedium>();

        }
        public int ProductId { get; set; } //klucz glowny
        public int MovieId { get; set; } //polaczone z jednym filmem
        public float Cost { get; set; }


        public virtual ICollection<Language> Languages { get; set; } //polaczone z wieloma jezykami
        public virtual ICollection<VideoTechnology> VideoTechnologys { get; set; }  //polaczone z wieloma technologiami obrazu
        public virtual ICollection<SoundTechnology> SoundTechnologys { get; set; }  //polaczone z wieloma technologiami dzwieku
        public virtual ICollection<StorageMedium> StorageMediums { get; set; }  //polaczone z wieloma typami nosnika
        public virtual ICollection<PhysicalProduct> PhysicalProducts { get; set; }  //polaczone z wieloma fizycznymi produktami
        public virtual Movie Movie { get; set; } //polaczone z jednym filmem

    }
}