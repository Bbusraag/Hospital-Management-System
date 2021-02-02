using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class DoktorAnaSayafa : Form
    {
        public DoktorAnaSayafa()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private DoktorKayıt doktorKayıt;
        private void KAYIT_Click(object sender, EventArgs e)
        {
            doktorKayıt = new DoktorKayıt();
            doktorKayıt.Show();
        }
        private RandevuSonuç randevuSonuç;
        private void Peynir_Click(object sender, EventArgs e)
        {
             randevuSonuç= new RandevuSonuç();
            randevuSonuç.Show();
        }
        private DoktorTahlilLab doktorTahlilLab;
        private void Bakla_Click(object sender, EventArgs e)
        {
            doktorTahlilLab = new DoktorTahlilLab();
            doktorTahlilLab.Show();
        }
        private GirişSayfa girişSayfa;
        private void button1_Click(object sender, EventArgs e)
        {
            girişSayfa = new GirişSayfa();
            girişSayfa.Show();
        
    }
    }
}
