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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Kapa_Click(object sender, EventArgs e)
        {

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void Altaindir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private HastaKayıt hastaKayıt;
        private void KAYIT_Click(object sender, EventArgs e)
        {
            hastaKayıt = new HastaKayıt();
            hastaKayıt.Show();
        }
        private RandevuTasarım randevuTasarım;
        private void Peynir_Click(object sender, EventArgs e)
        {
            randevuTasarım = new RandevuTasarım();
            randevuTasarım.Show();
        }
        private TahlilLab tahlilLab;
        private void Bakla_Click(object sender, EventArgs e)
        {
            tahlilLab = new TahlilLab();
            tahlilLab.Show();
        }
       /* private Radyoloji radyoloji;
        private void Adetli_Click(object sender, EventArgs e)
        {
            radyoloji = new Radyoloji();
            radyoloji.Show();
        }*/
       
        private void Et_Click(object sender, EventArgs e)
        {
           
        }
        private GirişSayfa girişSayfa;
        private void button1_Click(object sender, EventArgs e)
        {
            girişSayfa = new GirişSayfa();
            girişSayfa.Show();
        }
    }
}
