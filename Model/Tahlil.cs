using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class Tahlil
    {
        public int TahlilId { get; set; }
        public int? TahlilTürNo { get; set; }
        public int? SilindiMi { get; set; }

        public virtual TabloTahlilTür TahlilTürNoNavigation { get; set; }
    }
}
