using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentalOnline.Models
{
    public class Language
    {
        public Language() { }
        public int LanguageId { get; set; }   //klucz glowny
        public string Name { get; set; }
        public LanguageType LanguageType { get; set; }

        public virtual ICollection<Product> Products { get; set; } //polaczono z wieloma produktami

    }

    public enum LanguageType
    {
        Subtitles,
        VoiceOver,
        Dubbing
    }
}