using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TabloHemşire
    {
        public TabloHemşire()
        {
            TblHastane = new HashSet<TblHastane>();
        }

        public int HemşireId { get; set; }
        public int? TürNo { get; set; }
        public int? Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int? SilindiMi { get; set; }

        public virtual TabloHemşireTür TürNoNavigation { get; set; }
        public virtual ICollection<TblHastane> TblHastane { get; set; }
    }
}
