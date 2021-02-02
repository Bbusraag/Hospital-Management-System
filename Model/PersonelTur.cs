using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class PersonelTur
    {
        public PersonelTur()
        {
            TblPersoneller = new HashSet<TblPersoneller>();
        }

        public int PersonelTurId { get; set; }
        public string PersonelTurAd { get; set; }

        public virtual ICollection<TblPersoneller> TblPersoneller { get; set; }
    }
}
