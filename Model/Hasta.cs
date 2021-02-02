using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class Hasta
    {
        public Hasta()
        {
            Randevu = new HashSet<Randevu>();
        }

        public int HastaId { get; set; }
        public int? HastaTc { get; set; }
        public int? BölümId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? Yaş { get; set; }
        public string Cinsiyet { get; set; }
        public int? HastaNo { get; set; }
        public int? SilindiMi { get; set; }

        public virtual ICollection<Randevu> Randevu { get; set; }
    }
}
