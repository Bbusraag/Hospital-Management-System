using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TabloPersonel
    {
        public TabloPersonel()
        {
            TblHastane = new HashSet<TblHastane>();
        }

        public int PersonelId { get; set; }
        public int? PersonelTürId { get; set; }
        public int? Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? SilindiMi { get; set; }

        public virtual TabloPersonelTür PersonelTür { get; set; }
        public virtual ICollection<TblHastane> TblHastane { get; set; }
    }
}
