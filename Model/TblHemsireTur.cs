using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TblHemsireTur
    {
        public TblHemsireTur()
        {
            TblHemsireler = new HashSet<TblHemsireler>();
        }

        public int HemsireTurId { get; set; }
        public string HemsireTurAd { get; set; }
        public int? SilindiMi { get; set; }

        public virtual ICollection<TblHemsireler> TblHemsireler { get; set; }
    }
}
