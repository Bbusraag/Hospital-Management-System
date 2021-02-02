using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TabloPersonelTür
    {
        public TabloPersonelTür()
        {
            TabloPersonel = new HashSet<TabloPersonel>();
        }

        public int PersonelTürNo { get; set; }
        public string PersonelTürAd { get; set; }
        public int? SilindiMi { get; set; }

        public virtual ICollection<TabloPersonel> TabloPersonel { get; set; }
    }
}
