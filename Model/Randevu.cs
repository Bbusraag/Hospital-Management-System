using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class Randevu
    {
        public int RandevuId { get; set; }
        public int? BölümId { get; set; }
        public DateTime? Tarih { get; set; }
        public int? Saat { get; set; }
        public int? DoktorId { get; set; }
        public int? SilindiMi { get; set; }
        public int? HastaId { get; set; }

        public virtual Hasta Hasta { get; set; }
    }
}
