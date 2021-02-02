using System;
using System.Collections.Generic;

namespace Hastane_Proje.Model
{
    public partial class TblHemsireler
    {
        public int HemsireId { get; set; }
        public int? HemsireNo { get; set; }
        public int? HemsireTurId { get; set; }
        public string HemsireAd { get; set; }
        public string HemsireSoyad { get; set; }
        public int? HemsireTc { get; set; }
        public int? SilindiMi { get; set; }

        public virtual TblHemsireTur HemsireTur { get; set; }
    }
}
