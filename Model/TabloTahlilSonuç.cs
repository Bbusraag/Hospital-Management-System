using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TabloTahlilSonuç
    {
        public TabloTahlilSonuç()
        {
            TabloLaboratuvar = new HashSet<TabloLaboratuvar>();
            TabloRadyoloji = new HashSet<TabloRadyoloji>();
        }

        public int SonucId { get; set; }
        public int? HastaTc { get; set; }
        public int? SilindiMi { get; set; }
        public int? SonucNo { get; set; }

        public virtual ICollection<TabloLaboratuvar> TabloLaboratuvar { get; set; }
        public virtual ICollection<TabloRadyoloji> TabloRadyoloji { get; set; }
    }
}
