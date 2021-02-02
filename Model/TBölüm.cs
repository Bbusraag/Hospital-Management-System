using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TBölüm
    {
        public TBölüm()
        {
            Doktor = new HashSet<Doktor>();
            TblHastane = new HashSet<TblHastane>();
        }

        public int BölümIdPk { get; set; }
        public string BölümAd { get; set; }
        public int? SilindiMi { get; set; }

        public virtual ICollection<Doktor> Doktor { get; set; }
        public virtual ICollection<TblHastane> TblHastane { get; set; }
    }
}
