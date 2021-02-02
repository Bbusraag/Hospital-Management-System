using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class Doktor
    {
        public Doktor()
        {
            TblHastane = new HashSet<TblHastane>();
        }

        public int DoktorId { get; set; }
        public int? BölümId { get; set; }
        public int? Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? SilindiMi { get; set; }

        public virtual TBölüm Bölüm { get; set; }
        public virtual ICollection<TblHastane> TblHastane { get; set; }
    }
}
