using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TblHastane
    {
        public int HastaneId { get; set; }
        public string HastaneAd { get; set; }
        public int? BölümId { get; set; }
        public int? DoktorId { get; set; }
        public int? OdaNo { get; set; }
        public int? SilindiMi { get; set; }

        public virtual TBölüm Bölüm { get; set; }
        public virtual Doktor Doktor { get; set; }
        public virtual TabloOda OdaNoNavigation { get; set; }
    }
}
