using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TblPersoneller
    {
        public int PersonelId { get; set; }
        public int? PersonelTc { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string Adres { get; set; }
        public int? SilindiMi { get; set; }
    }
}
