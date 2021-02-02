using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TabloRadyoloji
    {
        public int TahlilId { get; set; }
        public int? HastaTc { get; set; }
        public int? DoktorId { get; set; }
        public int? SonucId { get; set; }
        public int RadyoId { get; set; }
        public int? SilindiMi { get; set; }

        public virtual TabloTahlilSonuç Sonuc { get; set; }
        public virtual TabloTahlilTür Tahlil { get; set; }
    }
}
