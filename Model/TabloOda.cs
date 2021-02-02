using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TabloOda
    {
        public TabloOda()
        {
            TblHastane = new HashSet<TblHastane>();
        }

        public int OdaId { get; set; }
        public int? OdaTürId { get; set; }
        public int? YatakSayı { get; set; }
        public int? SilindiMi { get; set; }

        public virtual ICollection<TblHastane> TblHastane { get; set; }
    }
}
