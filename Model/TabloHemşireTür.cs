using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TabloHemşireTür
    {
        public TabloHemşireTür()
        {
            TabloHemşire = new HashSet<TabloHemşire>();
        }

        public int TürNo { get; set; }
        public string TürAd { get; set; }
        public int? SilindiMi { get; set; }

        public virtual ICollection<TabloHemşire> TabloHemşire { get; set; }
    }
}
