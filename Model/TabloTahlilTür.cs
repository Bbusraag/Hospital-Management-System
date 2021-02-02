using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TabloTahlilTür
    {
        public TabloTahlilTür()
        {
            TabloLaboratuvar = new HashSet<TabloLaboratuvar>();
            TabloRadyoloji = new HashSet<TabloRadyoloji>();
        }

        public int TahlilId { get; set; }
        public string TahlilTürAd { get; set; }
        public int? SilindiMi { get; set; }

        public virtual ICollection<TabloLaboratuvar> TabloLaboratuvar { get; set; }
        public virtual ICollection<TabloRadyoloji> TabloRadyoloji { get; set; }
    }
}
