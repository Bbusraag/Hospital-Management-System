using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TarihSaat
    {
        public DateTime? Tarih { get; set; }
        public int? Saat { get; set; }

        public virtual TabloSaat SaatNavigation { get; set; }
        public virtual TabloTarih TarihNavigation { get; set; }
    }
}
